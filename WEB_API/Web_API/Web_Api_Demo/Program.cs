using Web_Api_Demo.Services;

namespace Web_Api_Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Go and create builder with default configuration
           
            var builder = WebApplication.CreateBuilder(args);
           

            // Add services to the container.
            builder.Services.AddSingleton<IStudentService, StudentService>();
            builder.Services.AddControllers();

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}