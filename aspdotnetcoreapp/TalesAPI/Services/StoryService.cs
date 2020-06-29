namespace TalesAPI.Services
{
    using NLog;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ServiceInterfaces;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using TalesApp.Domain.Services.Communication;

    public class StoryService : IStoryService
    {
        private readonly IStoryRepository _storyRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public StoryService(IStoryRepository storyRepository, IUnitOfWork unitOfWork)
        {
            _storyRepository = storyRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<Story>> StoriesBySetId(Guid setId)
        {
            return await _storyRepository.StoriesBySetId(setId);
        }

        public async Task<Story> FindAsync(Guid id)
        {
            return await _storyRepository.FindAsync(id);
        }

        public async Task<Response<Story>> SaveAsync(Story story)
        {
            try
            {
                await _storyRepository.AddAsync(story);
                await _unitOfWork.SaveChangesAsync();
                return new Response<Story>(story);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error saving new Story: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<Story>($"The story '{story.StoryName}' could not be saved. An error occured: {exception.Message}");
            }
        }

        public async Task<Response<Story>> UpdateAsync(Story story)
        {
            var existingSequence = await _storyRepository.FindAsync(story.StoryId);

            if (existingSequence == null)
                return new Response<Story>($"Story with id '{story.StoryId}' was not found. Update operation failed.");

            existingSequence.StoryName = story.StoryName;
            existingSequence.StoryCoverImage = story.StoryCoverImage;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<Story>(existingSequence);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error updating Story: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<Story>($"An error occurred when updating the story with id '{story.StoryId}': {exception.Message}");
            }
        }

        public async Task<Response<Story>> DeleteAsync(Guid id)
        {
            var existingCategory = await _storyRepository.FindAsync(id);

            if (existingCategory == null)
                return new Response<Story>($"Story with id '{id}' was not found. Delete operation failed.");

            try
            {
                _storyRepository.Remove(existingCategory);
                await _unitOfWork.SaveChangesAsync();

                return new Response<Story>(existingCategory);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error saving new Story: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<Story>($"An error occurred when deleting the story with id '{id}': {exception.Message}");
            }
        }
    }
}
