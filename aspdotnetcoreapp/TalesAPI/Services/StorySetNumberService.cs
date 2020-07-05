namespace TalesAPI.Services
{
    using NLog;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using TalesApp.Domain.Services.Communication;

    public class StorySetNumberService : IStorySetNumberService
    {
        private readonly IRepository<StorySetNumber> _storySetNumberRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public StorySetNumberService(IRepository<StorySetNumber> storySetNumberRepository, IUnitOfWork unitOfWork)
        {
            _storySetNumberRepository = storySetNumberRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StorySetNumber>> ListAsync()
        {
            return await _storySetNumberRepository.ListAsync();
        }

        public async Task<StorySetNumber> FindAsync(Guid id)
        {
            return await _storySetNumberRepository.FindAsync(id);
        }

        public async Task<Response<StorySetNumber>> SaveAsync(StorySetNumber storySetNumber)
        {
            try
            {
                await _storySetNumberRepository.AddAsync(storySetNumber);
                await _unitOfWork.SaveChangesAsync();
                return new Response<StorySetNumber>(storySetNumber);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error saving new Story Set Number: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<StorySetNumber>(exception.Message);
            }
        }

        public async Task<Response<StorySetNumber>> UpdateAsync(StorySetNumber storySetNumber)
        {
            var existingSequence = await _storySetNumberRepository.FindAsync(storySetNumber.StorySetId);

            if (existingSequence == null)
                return new Response<StorySetNumber>($"The number of the Story with ID '{storySetNumber.StorySetId}' not found.");

            existingSequence.SetNumber = storySetNumber.SetNumber;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySetNumber>(existingSequence);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error updating Story Set Number: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<StorySetNumber>($"An error occurred when updating " +
                                                    $"the Story Number with id '{storySetNumber.StorySetId}': {exception.Message}");
            }
        }

        public async Task<Response<StorySetNumber>> DeleteAsync(Guid id)
        {
            var existingCategory = await _storySetNumberRepository.FindAsync(id);

            if (existingCategory == null)
                return new Response<StorySetNumber>($"The Story Set with id '{id}' was not found");

            try
            {
                _storySetNumberRepository.Remove(existingCategory);
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySetNumber>(existingCategory);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error deleting Story Set Number: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<StorySetNumber>($"An error occurred when deleting the Story Set with id '{id}': {exception.Message}");
            }
        }
    }
}
