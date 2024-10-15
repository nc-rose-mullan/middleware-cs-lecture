using Microsoft.AspNetCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace Middleware.Middleware
{
    public class ExceptionHandlerMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }
        private async Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            Console.WriteLine("SENDING ERROR MESSAGE");

            context.Response.StatusCode = StatusCodes.Status500InternalServerError;

            context.Response.ContentType = "application/json";

            var errorResponse = new
            {
                message = ex.Message,
                details = (ex as ValidationException)?.ValidationResult // Example for validation exception
            };

            // Write the response as JSON
            await context.Response.WriteAsJsonAsync(errorResponse);
        }
    }
}
