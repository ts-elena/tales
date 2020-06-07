namespace TalesAPI.Services
{
    using NLog;
    using ServiceInterfaces;
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
        private readonly Logger Logger = LogManager.GetCurrentClassLogger();

        public CharacterService(ICharacterRepository characterRepository, IUnitOfWork unitOfWork)
        {
            _characterRepository = characterRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Character> FindAsync(Guid id)
        {
            return await _characterRepository.FindAsync(id);
        }

        public async Task<Response<IEnumerable<Character>>> SaveRangeAsync(List<Character> character)
        {
            try
            {
                await _characterRepository.AddRangeAsync(character);
                await _unitOfWork.SaveChangesAsync();
                return new Response<IEnumerable<Character>>(character);
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"Error when saving characters: {exception.Message}. Inner exception: {exception.InnerException}");
                return new Response<IEnumerable<Character>>(exception.Message);
            }
        }

        public async Task<Response<IEnumerable<Character>>> UpdateRangeAsync(List<Character> charactersToUpdate)
        {
            try
            {
                _characterRepository.UpdateRange(charactersToUpdate);
                await _unitOfWork.SaveChangesAsync();
                return new Response<IEnumerable<Character>>(charactersToUpdate);
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"Error when updating characters: {exception.Message}. Inner exception: {exception.InnerException}");
                return new Response<IEnumerable<Character>>($"An error occurred when updating the sequence: {exception.Message}");
            }
        }

        public async Task<Response<IEnumerable<Character>>> DeleteAsync(List<Character> charactersToDelete)
        {
            try
            {
                _characterRepository.RemoveRange(charactersToDelete);
                await _unitOfWork.SaveChangesAsync();

                return new Response<IEnumerable<Character>>(charactersToDelete);
            }
            catch (Exception exception)
            {
                Logger.Error(exception, $"Error when deleting characters: {exception.Message}. Inner exception: {exception.InnerException}");
                return new Response<IEnumerable<Character>>($"An error occurred when deleting the character: {exception.Message}");
            }
        }
    }
}
