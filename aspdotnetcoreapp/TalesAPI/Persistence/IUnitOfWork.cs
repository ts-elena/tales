namespace TalesAPI.Persistence
{
    using System.Threading.Tasks;
    using TalesAPI.Persistence.Repositories;
    using TalesApp.Domain;

    public interface IUnitOfWork
    {
        BaseRepository<StorySet> StorySet { get; }
        BaseRepository<StorySetNumber> StorySetNumber { get; }
        StoryRepository Story { get; }
        BaseRepository<Character> Character { get; }
        LineRepository Line { get; }
        LineNumberRepository LineNumber { get; }
        Task Complete();
    }
}
