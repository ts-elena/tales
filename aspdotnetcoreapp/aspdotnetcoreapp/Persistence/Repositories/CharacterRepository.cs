namespace aspdotnetcoreapp.Persistence.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Data;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class CharacterRepository : BaseRepository, ICharacterRepository
    {
        public CharacterRepository(TalesContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Character>> ListAsync()
        {
            return await _context.Character
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<Character> FindAsync(Guid id)
        {
            return await _context.Character.FindAsync(id);
        }

        public void Update(Character character)
        {
            _context.Character.Update(character);
        }

        public async Task AddAsync(Character character)
        {
            await _context.Character.AddAsync(character);
        }

        public void Remove(Character character)
        {
            _context.Character.Remove(character);
        }
    }
}
