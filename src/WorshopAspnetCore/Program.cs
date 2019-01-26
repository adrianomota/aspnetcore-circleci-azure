using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace WorshopAspnetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                   .UseUrls("http://localhost:5000",
                            "http://192.168.1.104:5000")
                   .UseStartup<Startup>();
    }
}