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

    public class StorySetService : IStorySetService
    {
        private readonly IStorySetRepository _storySetRepository;
        private readonly IUnitOfWork _unitOfWork;

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
                return new Response<StorySet>(exception.Message);
            }
        }

        public async Task<Response<StorySet>> UpdateAsync(Guid id, StorySet storySetsSequence)
        {
            var existingSequence = await _storySetRepository.FindAsync(id);

            if (existingSequence == null)
                return new Response<StorySet>($"Story sequence with ID '{id}' not found.");

            existingSequence.StorySetName = storySetsSequence.StorySetName;
            existingSequence.StorySetNumber = storySetsSequence.StorySetNumber;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySet>(existingSequence);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<StorySet>($"An error occurred when updating the sequence: {ex.Message}");
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
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<StorySet>($"An error occurred when deleting the category: {ex.Message}");
            }
        }
    }
}
