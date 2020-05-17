using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Data;
using TalesApp.Domain;
using TalesApp.Domain.Services;

namespace aspdotnetcoreapp.Persistence.Repositories
{
    public class StorySetsSequenceRepository: BaseRepository, IRepository<StorySetsSequence>
    {
        public StorySetsSequenceRepository(TalesContext context): base(context)
        {

        }

        public async Task<IEnumerable<StorySetsSequence>> ListAsync()
        {
            return await _context.StorySetsSequences
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<StorySetsSequence> FindAsync(Guid id)
        {
            return await _context.StorySetsSequences.FindAsync(id);
        }

        public void Update(StorySetsSequence storySetsSequence)
        {
            _context.StorySetsSequences.Update(storySetsSequence);
        }

        public async Task AddAsync(StorySetsSequence storySetsSequence)
        {
            await _context.StorySetsSequences.AddAsync(storySetsSequence);
        }

        public void Remove(StorySetsSequence category)
        {
            _context.StorySetsSequences.Remove(category);
        }
    }
}
