namespace TalesAPI.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class StorySetRepository : BaseRepository, IStorySetRepository
    {
        public StorySetRepository(TalesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<StorySet>> ListAsync()
        {
            return await _context.StorySet
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<StorySet> FindAsync(Guid id)
        {
            return await _context.StorySet.FindAsync(id);
        }

        public void Update(StorySet storySet)
        {
            _context.StorySet.Update(storySet);
        }

        public async Task AddAsync(StorySet storySet)
        {
            await _context.StorySet.AddAsync(storySet);
        }

        public void Remove(StorySet storySet)
        {
            _context.StorySet.Remove(storySet);
        }
    }
}
