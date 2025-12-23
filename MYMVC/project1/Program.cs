namespace project1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            /*app.MapGet("/", () => "Hello World!");*/

            app.Run(async(HttpContext context)=>

                {
                    context.Response.StatusCode = 200;
                    await context.Response.WriteAsync("Hello from custom middleware!");
            });
        }
    }
}
