using System.Linq;

namespace TalesAPI.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class StoryRepository : BaseRepository, IStoryRepository
    {
        public StoryRepository(TalesContext context) : base(context)
        {
        }

        public async Task<List<Story>> ActiveStoriesBySetId(Guid setId)
        {
            return await _context.Story
                .Where(story => story.StorySetId == setId && story.IsActive)
                .ToListAsync();
        }

        public async Task<Story> FindAsync(Guid id)
        {
            return await _context.Story.FindAsync(id);
        }

        public void Update(Story story)
        {
            _context.Story.Update(story);
        }

        public async Task AddAsync(Story story)
        {
            await _context.Story.AddAsync(story);
        }

        public void Remove(Story story)
        {
            _context.Story.Remove(story);
        }
    }
}
