namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDictionaryWordRepository
    {
        Task<IEnumerable<DictionaryWord>> ListAsync();
        Task<DictionaryWord> FindAsync(Guid id);
        void Update(DictionaryWord dbObject);
        Task AddAsync(DictionaryWord dbObject);
        void Remove(DictionaryWord dbObject);
    }
}
