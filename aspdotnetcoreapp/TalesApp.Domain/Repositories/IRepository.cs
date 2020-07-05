namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IRepository<T> where T: class
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindAsync(Guid id);
        void UpdateRange(IEnumerable<T> dbItem);
        void Update(T dbItem);
        Task AddRangeAsync(IEnumerable<T> dbItem);
        Task AddAsync(T dbItem);
        void RemoveRange(IEnumerable<T> dbItem);
        void Remove(T dbItem);
    }
}
