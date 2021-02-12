using System.Threading.Tasks;
namespace Domain.Interfaces
{
    public interface IServiceA 
    {
        Task DoSomething();
        Task PrintSettings();
    }
}