using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Services
{
    public class ServiceA : IServiceA
    {
        private readonly IServiceB _serviceB;
        public ServiceA(IServiceB serviceB)
        {
            _serviceB = serviceB;
        }

        public async Task DoSomething() => await _serviceB.DoSomething();

        public async Task PrintSettings() => await _serviceB.PrintSettings();
    }
}