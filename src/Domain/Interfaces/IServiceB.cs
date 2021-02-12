using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IServiceB 
    {
        Task DoSomething();
        Task PrintSettings();
    }
}