namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineRepository
    {
        Task<Line> LineByIdOrDefault(Guid id);
        void UpdateRange(IEnumerable<Line> dbObjects);
        Task AddRangeAsync(IEnumerable<Line> dbObjects);
        void RemoveRange(IEnumerable<Line> dbObjects);
    }
}
