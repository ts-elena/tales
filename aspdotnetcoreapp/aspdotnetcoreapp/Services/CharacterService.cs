namespace aspdotnetcoreapp.Services
{
    using aspdotnetcoreapp.Services.ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using TalesApp.Domain.Services.Communication;

    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository _characterRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CharacterService(ICharacterRepository characterRepository, IUnitOfWork unitOfWork)
        {
            _characterRepository = characterRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Character>> ListAsync()
        {
            return await _characterRepository.ListAsync();
        }

        public async Task<Character> FindAsync(Guid id)
        {
            return await _characterRepository.FindAsync(id);
        }

        public async Task<Response<Character>> SaveAsync(Character character)
        {
            try
            {
                await _characterRepository.AddAsync(character);
                await _unitOfWork.SaveChangesAsync();
                return new Response<Character>(character);
            }
            catch (Exception exception)
            {
                return new Response<Character>(exception.Message);
            }
        }

        public async Task<Response<Character>> UpdateAsync(Guid id, Character characterToUpdate)
        {
            var characterWithId = await _characterRepository.FindAsync(id);

            if (characterWithId == null)
                return new Response<Character>($"Story sequence with ID '{id}' not found.");

            characterWithId.CharacterName = characterToUpdate.CharacterName;
            characterWithId.CharacterAvatar = characterToUpdate.CharacterAvatar;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<Character>(characterWithId);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<Character>($"An error occurred when updating the sequence: {ex.Message}");
            }
        }

        public async Task<Response<Character>> DeleteAsync(Guid id)
        {
            var characterById = await _characterRepository.FindAsync(id);

            if (characterById == null)
                return new Response<Character>($"Character with id '{id}' was not found.");

            try
            {
                _characterRepository.Remove(characterById);
                await _unitOfWork.SaveChangesAsync();

                return new Response<Character>(characterById);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<Character>($"An error occurred when deleting the character: {ex.Message}");
            }
        }
    }
}
