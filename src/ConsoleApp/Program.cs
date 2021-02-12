using Application.Settings;
using Domain.Services;
using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        private static IConfiguration Configuration { get; set;}
        static async Task Main(string[] args)
        {
            Configuration = new ConfigurationBuilder()
                                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                                .AddEnvironmentVariables()
                                .AddCommandLine(args)
                                .Build();

            var services = new ServiceCollection();
            ConfigureServices(services);
            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                Application app = serviceProvider.GetService<Application>();
                await app.Run();
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            var appSettings = new AppSettings(); 
                                Configuration.Bind("AppSettings", appSettings);  
                                services.AddSingleton(appSettings);

            services.AddLogging(configure => configure.AddConsole())
                    .AddTransient<Application>()
                    .AddTransient<IServiceA, ServiceA>()
                    .AddTransient<IServiceB, ServiceB>();
        }
    }
}
