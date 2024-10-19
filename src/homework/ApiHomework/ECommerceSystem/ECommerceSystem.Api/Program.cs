using ECommerceSystem.Api.Services;
using ECommerceSystem.Api.Repositories;

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

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
