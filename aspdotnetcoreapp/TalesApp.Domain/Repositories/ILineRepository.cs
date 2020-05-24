namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineRepository
    {
        Task<IEnumerable<Line>> ListAsync();
        Task<Line> FindAsync(Guid id);
        void Update(Line dbObject);
        Task AddAsync(Line dbObject);
        void Remove(Line dbObject);
    }
}
