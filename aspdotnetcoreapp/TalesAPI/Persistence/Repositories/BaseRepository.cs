namespace TalesAPI.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain.Repositories;

    public class BaseRepository<T>: IRepository<T> where T: class
    {
        protected readonly DbSet<T> _entities;
        protected readonly TalesContext _context;

        public BaseRepository(TalesContext context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<IEnumerable<T>> ListAsync()
        {
            return await _entities.AsNoTracking().ToListAsync();
        }

        public async Task<T> FindAsync(Guid id)
        {
            return await _entities.FindAsync(id);
        }

        public void UpdateRange(IEnumerable<T> dbItem)
        {
            _entities.UpdateRange(dbItem);
        }

        public void Update(T dbItem)
        {
            _entities.Update(dbItem);
        }

        public async Task AddRangeAsync(IEnumerable<T> dbItem)
        {
            await _entities.AddRangeAsync(dbItem);
        }

        public async Task AddAsync(T dbItem)
        {
            await _entities.AddAsync(dbItem);
        }

        public void RemoveRange(IEnumerable<T> dbItem)
        {
            _entities.RemoveRange(dbItem);
        }

        public void Remove(T dbItem)
        {
            _entities.Remove(dbItem);
        }
    }
}
