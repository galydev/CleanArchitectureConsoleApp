using Domain.Interfaces;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using System;

namespace ConsoleApp
{
    public class Application
    {
        private readonly ILogger _logger;
        private readonly IServiceA _serviceA;
        public Application(ILogger<Application> logger, IServiceA serviceA)
        {
            _logger = logger;
            _serviceA = serviceA;
        }

        internal async Task Run()
        {
            _logger.LogInformation("Application {applicationEvent} at {dateTime}", "Started", DateTime.UtcNow);
            await _serviceA.DoSomething();
            _logger.LogInformation("Application {applicationEvent} at {dateTime}", "Ended", DateTime.UtcNow);

            Console.WriteLine("PRESS <ENTER> TO EXIT");
            Console.ReadKey();
        }
    }
}