namespace aspdotnetcoreapp.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class LineNumberRepository : BaseRepository, ILineNumberRepository
    {
        public LineNumberRepository(TalesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<LineNumber>> ListAsync()
        {
            return await _context.LineNumber
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<LineNumber> FindAsync(Guid id)
        {
            return await _context.LineNumber.FindAsync(id);
        }

        public void Update(LineNumber lineNumber)
        {
            _context.LineNumber.Update(lineNumber);
        }

        public async Task AddAsync(LineNumber lineNumber)
        {
            await _context.LineNumber.AddAsync(lineNumber);
        }

        public void Remove(LineNumber lineNumber)
        {
            _context.LineNumber.Remove(lineNumber);
        }
    }
}
