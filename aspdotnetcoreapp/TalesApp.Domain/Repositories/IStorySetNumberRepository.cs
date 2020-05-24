namespace TalesApp.Domain.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStorySetNumberRepository
    {
        Task<IEnumerable<StorySetNumber>> ListAsync();
        Task<StorySetNumber> FindAsync(Guid id);
        void Update(StorySetNumber dbObject);
        Task AddAsync(StorySetNumber dbObject);
        void Remove(StorySetNumber dbObject);
    }
}
