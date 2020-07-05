namespace TalesAPI.Persistence.Repositories
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
        public LineRepository(TalesContext context) : base(context) { }

        public async Task<IEnumerable<Line>> ListAsync() =>
            await _context.Line
                .AsNoTracking()
                .ToListAsync();

        public async Task<Line> LineByIdOrDefault(Guid id) => await _context.Line.FirstOrDefaultAsync(line => line.LineId == id);

        public void Update(Line line) => _context.Line.Update(line);

        public void UpdateRange(IEnumerable<Line> dbObjects) => _context.Line.UpdateRange(dbObjects);

        public async Task AddAsync(Line line) => await _context.Line.AddAsync(line);

        public async Task AddRangeAsync(IEnumerable<Line> dbObjects) => await _context.AddRangeAsync(dbObjects);

        public void DeleteRange(IEnumerable<Line> dbObjects) => _context.DeleteRange(dbObjects);
    }
}
