namespace aspdotnetcoreapp.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class LineRepository : BaseRepository, ILineRepository
    {
        public LineRepository(TalesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Line>> ListAsync()
        {
            return await _context.Line
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Line> FindAsync(Guid id)
        {
            return await _context.Line.FindAsync(id);
        }

        public void Update(Line line)
        {
            _context.Line.Update(line);
        }

        public async Task AddAsync(Line line)
        {
            await _context.Line.AddAsync(line);
        }

        public void Remove(Line line)
        {
            _context.Line.Remove(line);
        }
    }
}
