using ECommerceSystem.Api.Services;
using ECommerceSystem.Api.Repositories;
using Microsoft.AspNetCore.Http.Extensions;
using System.Reflection;
using ECommerceSystem.Api.Middleware;

namespace ECommerceSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            var x = builder.Services.ToList();
            // Add services to the container.
            builder.Services.AddSingleton<CategoriesRepository>();
            builder.Services.AddSingleton<CustomersRepository>();
            builder.Services.AddSingleton<OrdersRepository>();
            builder.Services.AddSingleton<ProductsRepository>();
            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<CustomerService>();
            builder.Services.AddSingleton<OrderService>();
            builder.Services.AddSingleton<ProductService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            
            // logging middleware
            app.Use(async (context, next) =>
                {
                    Console.WriteLine($"[Logging Middleware] HTTP Request Method: {context.Request.Method}, Request URL: {context.Request.GetDisplayUrl()}, Request Timestamp: {DateTime.UtcNow}");
                    
                    // Call the next middleware in the pipeline
                    await next(context);

                    Console.WriteLine($"[Logging Middleware] HTTP Response Status Code: {context.Response.StatusCode}, Response Timestamp: {context.Response.Headers["Date"]}");
                });

            //conditional middleware
            app.Use(async (context, next) =>
            {
                if (context.Request.Method == "POST")
                Console.WriteLine($"[Conditional Middleware] HTTP Request Method is POST");

                await next(context);

            });

            app.UseMiddleware<CustomResponseHeaderMiddleware>();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
