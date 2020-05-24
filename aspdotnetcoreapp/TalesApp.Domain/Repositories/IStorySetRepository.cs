namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStorySetRepository
    {
        Task<IEnumerable<StorySet>> ListAsync();
        Task<StorySet> FindAsync(Guid id);
        void Update(StorySet dbObject);
        Task AddAsync(StorySet dbObject);
        void Remove(StorySet dbObject);
    }
}
