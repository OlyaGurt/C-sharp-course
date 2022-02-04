using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Worms
{
    class Program
    {
        public static void Main(string[] args)

        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args)

        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>

                {
                    services.AddHostedService<WorldSimulatorService>();
                    
                    services.AddScoped<FileWriterService>(); 
                    services.AddScoped<NameGenerator>();
                    services.AddScoped<FoodGenerator>();
                    services.AddScoped<WormLogic>();
                    services.AddScoped<Food>();
                    
                });
        }
    }
}