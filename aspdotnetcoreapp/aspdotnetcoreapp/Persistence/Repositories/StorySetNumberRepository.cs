namespace aspdotnetcoreapp.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Services;

    public class StorySetNumberRepository: BaseRepository, IStorySetNumberRepository
    {
        public StorySetNumberRepository(TalesContext context): base(context) { }

        public async Task<IEnumerable<StorySetNumber>> ListAsync()
        {
            return await _context.StorySetNumber
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<StorySetNumber> FindAsync(Guid id)
        {
            return await _context.StorySetNumber.FindAsync(id);
        }

        public void Update(StorySetNumber storySetsSequence)
        {
            _context.StorySetNumber.Update(storySetsSequence);
        }

        public async Task AddAsync(StorySetNumber storySetsSequence)
        {
            await _context.StorySetNumber.AddAsync(storySetsSequence);
        }

        public void Remove(StorySetNumber category)
        {
            _context.StorySetNumber.Remove(category);
        }
    }
}
