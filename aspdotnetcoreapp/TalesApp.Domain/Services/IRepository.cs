using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Domain.Services.Communication;

namespace TalesApp.Domain.Services
{
    /// <summary>
    /// Describes required menthods for a repository
    /// </summary>
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindAsync(Guid id);
        void Update(T dbObject);
        Task AddAsync(T dbObject);
        void Remove(T dbObject);
    }
}
