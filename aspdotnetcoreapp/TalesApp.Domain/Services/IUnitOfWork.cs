using System.Threading.Tasks;

namespace TalesApp.Domain.Services
{
    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
