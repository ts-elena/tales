namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineNumberRepository
    {
        Task<LineNumber> LineNumberById(Guid id);
        Task<LineNumber> LineNumbersOfStory(Guid id, int lineNumber);
        void UpdateRange(IEnumerable<LineNumber> dbObjects);
        Task AddRangeAsync(IEnumerable<LineNumber> dbObjects);
        void DeleteRange(IEnumerable<LineNumber> dbObjects);
    }
}
