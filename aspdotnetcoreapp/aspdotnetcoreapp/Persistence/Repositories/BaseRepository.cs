namespace aspdotnetcoreapp.Persistence.Repositories
{
    using TalesApp.Data;

    public abstract class BaseRepository
    {
        protected readonly TalesContext _context;

        public BaseRepository(TalesContext context)
        {
            _context = context;
        }
    }
}
