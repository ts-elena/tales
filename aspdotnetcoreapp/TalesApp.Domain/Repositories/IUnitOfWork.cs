namespace TalesApp.Domain.Services
{
    using System.Threading.Tasks;

    public interface IUnitOfWork
    {
        Task SaveChangesAsync();
    }
}
