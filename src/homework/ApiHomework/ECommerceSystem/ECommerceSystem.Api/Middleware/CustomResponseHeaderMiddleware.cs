using System.Reflection;

namespace ECommerceSystem.Api.Middleware
{
    public class CustomResponseHeaderMiddleware
    {
        private readonly RequestDelegate _next;

        public CustomResponseHeaderMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.OnStarting(() =>
            {
                string middlewareName = this.GetType().Name;
                context.Response.Headers.Append("X-Custom-Header-Middleware-Test", $"{middlewareName} {DateTime.UtcNow}");
                return Task.FromResult(0);
            });
            await _next(context);
        }
    }
}
