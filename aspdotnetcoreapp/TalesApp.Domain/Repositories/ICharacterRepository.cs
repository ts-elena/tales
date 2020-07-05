namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ICharacterRepository
    {
        Task<IEnumerable<Character>> ListAsync();
        Task<Character> FindAsync(Guid id);
        void UpdateRange(IEnumerable<Character> characters);
        Task AddRangeAsync(IEnumerable<Character> character);
        void DeleteRange(IEnumerable<Character> character);
    }
}
