namespace aspdotnetcoreapp.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class DictionaryWordRepository : BaseRepository, IDictionaryWordRepository
    {
        public DictionaryWordRepository(TalesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DictionaryWord>> ListAsync()
        {
            return await _context.DictionaryWord
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<DictionaryWord> FindAsync(Guid id)
        {
            return await _context.DictionaryWord.FindAsync(id);
        }

        public void Update(DictionaryWord dictionaryWord)
        {
            _context.DictionaryWord.Update(dictionaryWord);
        }

        public async Task AddAsync(DictionaryWord dictionaryWord)
        {
            await _context.DictionaryWord.AddAsync(dictionaryWord);
        }

        public void Remove(DictionaryWord dictionaryWord)
        {
            _context.DictionaryWord.Remove(dictionaryWord);
        }
    }
}
