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

    public class StoryRepository : BaseRepository<Story>, IStoryRepository
    {
        public StoryRepository(TalesContext context) : base(context)
        {
        }

        public async Task<List<Story>> StoriesBySetId(Guid setId)
        {
            return await _context.Story
                .Where(story => story.StorySetId == setId)
                .ToListAsync();
        }
    }
}
