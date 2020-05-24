namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineNumberRepository
    {
        Task<IEnumerable<LineNumber>> ListAsync();
        Task<LineNumber> FindAsync(Guid id);
        void Update(LineNumber dbObject);
        Task AddAsync(LineNumber dbObject);
        void Remove(LineNumber dbObject);
    }
}
