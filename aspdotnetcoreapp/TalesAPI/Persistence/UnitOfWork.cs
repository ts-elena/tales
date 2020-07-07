namespace TalesAPI.Persistence
{
    using System.Threading.Tasks;
    using TalesAPI.Persistence.Repositories;
    using TalesApp.Data;
    using TalesApp.Domain;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly TalesContext _context;

        public BaseRepository<StorySet> StorySet { get; private set; } 
        public BaseRepository<StorySetNumber> StorySetNumber { get; private set; } 
        public StoryRepository Story { get; private set; } 
        public BaseRepository<Character> Character { get; private set; } 
        public LineRepository Line { get; private set; } 
        public LineNumberRepository LineNumber { get; private set; } 

        public UnitOfWork(TalesContext context)
        {
            _context = context;
            StorySet = new BaseRepository<StorySet>(context);
            StorySetNumber = new BaseRepository<StorySetNumber>(context);
            Story = new StoryRepository(context);
            Character = new BaseRepository<Character>(context);
            Line = new LineRepository(context);
            LineNumber = new LineNumberRepository(context);
        }

        public async Task Complete()
        {
            await _context.SaveChangesAsync();
        }
    }
}
