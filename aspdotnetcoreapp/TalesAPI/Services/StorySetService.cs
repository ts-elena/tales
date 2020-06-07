namespace TalesAPI.Services
{
    using Microsoft.Extensions.Logging;
    using NLog;
    using ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using TalesApp.Domain.Services.Communication;

    public class StorySetService : IStorySetService
    {
        private readonly IStorySetRepository _storySetRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public StorySetService(IStorySetRepository storySetRepository, IUnitOfWork unitOfWork)
        {
            _storySetRepository = storySetRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StorySet>> ListAsync()
        {
            return await _storySetRepository.ListAsync();
        }

        public async Task<StorySet> FindAsync(Guid id)
        {
            return await _storySetRepository.FindAsync(id);
        }

        public async Task<Response<StorySet>> SaveAsync(StorySet storySetsSequence)
        {
            try
            {
                await _storySetRepository.AddAsync(storySetsSequence);
                await _unitOfWork.SaveChangesAsync();
                return new Response<StorySet>(storySetsSequence);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error saving new Story Set: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<StorySet>(exception.Message);
            }
        }

        public async Task<Response<StorySet>> UpdateAsync(StorySet storySetNumber)
        {
            var existingSequence = await _storySetRepository.FindAsync(storySetNumber.StorySetId);

            if (existingSequence == null)
                return new Response<StorySet>($"Story sequence with ID '{storySetNumber.StorySetId}' not found.");

            existingSequence.StorySetName = storySetNumber.StorySetName;
            existingSequence.StorySetNumber = storySetNumber.StorySetNumber;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySet>(existingSequence);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error saving new Story Set: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<StorySet>($"An error occurred when updating the sequence: {exception.Message}");
            }
        }

        public async Task<Response<StorySet>> DeleteAsync(Guid id)
        {
            var existingCategory = await _storySetRepository.FindAsync(id);

            if (existingCategory == null)
                return new Response<StorySet>("Category not found.");

            try
            {
                _storySetRepository.Remove(existingCategory);
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySet>(existingCategory);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error deleting new Story Set: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<StorySet>($"An error occurred when deleting the category: {exception.Message}");
            }
        }
    }
}
