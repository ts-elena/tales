namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> ListAsync();
        Task<Character> FindAsync(Guid id);
        void Update(Character dbObject);
        Task AddAsync(Character dbObject);
        void Remove(Character dbObject);
    }
}
