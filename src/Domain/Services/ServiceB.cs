
using Microsoft.Extensions.Logging;
using Domain.Interfaces;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceB : IServiceB
    {
        private readonly ILogger<ServiceB> _logger;
        public ServiceB(ILogger<ServiceB> logger)
        {
            _logger = logger;
        }

        public async Task DoSomething() => await Task.Run(() => _logger.LogInformation("Service B is doing something.."));

        public async Task PrintSettings() => await Task.Run(() => _logger.LogInformation("Service B is doing something.."));
    }
}