
namespace Middleware.Middleware
{
    public class MyMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            Console.WriteLine("STARTING THE MIDDLEWARE CHAIN");

            var method = context.Request.Method;
            var path = context.Request.Path;
            var time = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            var inputLog = $"{time}: {method} {path}\n";

            File.AppendAllText("ServerLogs.txt", inputLog);

            await next.Invoke(context);

            var statusCode = context.Response.StatusCode;

            Console.WriteLine(statusCode);

            var outputLog = $"{statusCode}\n";

            File.AppendAllText("ServerLogs.txt", outputLog);

            Console.WriteLine("ENDING THE MIDDLEWARE CHAIN");
        }
    }
}