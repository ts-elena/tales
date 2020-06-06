namespace TalesAPI.Persistence.Repositories
{
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain.Services;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly TalesContext _context;

        public UnitOfWork(TalesContext context)
        {
            _context = context;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
