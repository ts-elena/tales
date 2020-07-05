namespace TalesAPI.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class LineRepository : BaseRepository<Line>, ILineRepository
    {
        public LineRepository(TalesContext context) : base(context) { }

        public async Task<Line> LineByIdOrDefault(Guid id) => await _context.Line.FirstOrDefaultAsync(line => line.LineId == id);

        public void DeleteRange(IEnumerable<Line> dbObjects) => _context.RemoveRange(dbObjects);
    }
}
