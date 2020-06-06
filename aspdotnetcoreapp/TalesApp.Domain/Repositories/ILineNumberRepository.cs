namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineNumberRepository
    {
        Task<LineNumber> LineNumberById(Guid id);
        Task<List<LineNumber>> LineNumbersOfStory(Guid id);
        void UpdateRange(IEnumerable<LineNumber> dbObjects);
        Task AddRangeAsync(IEnumerable<LineNumber> dbObjects);
        void DeleteRange(IEnumerable<LineNumber> dbObjects);
    }
}
