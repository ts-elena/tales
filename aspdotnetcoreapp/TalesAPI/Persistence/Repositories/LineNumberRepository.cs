namespace TalesAPI.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class LineNumberRepository : BaseRepository<LineNumber>, ILineNumberRepository
    {
        public LineNumberRepository(TalesContext context) : base(context)
        {
        }

        public async Task<LineNumber> LineNumberById(Guid id)
        {
            return await _context.LineNumber.FirstOrDefaultAsync(lineNumber => lineNumber.LineId == id);
        }

        public async Task<LineNumber> LineNumbersOfStory(Guid id, int lineNumber)
        {
            return await _context.LineNumber.FirstOrDefaultAsync((LineNumber num) => num.StoryId == id
                                                                       && num.Number == lineNumber);
        }

        public void DeleteRange(IEnumerable<LineNumber> dbObjects)
        {
            _context.LineNumber.RemoveRange(dbObjects);
        }
    }
}
