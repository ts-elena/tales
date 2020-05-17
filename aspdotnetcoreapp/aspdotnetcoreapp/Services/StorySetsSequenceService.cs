using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Domain;
using TalesApp.Domain.Services;
using TalesApp.Domain.Services.Communication;

namespace aspdotnetcoreapp.Services
{
    public class StorySetsSequenceService: IService<StorySetsSequence>
    {
        private readonly IRepository<StorySetsSequence> _storySetsSequenceRepository;
        private readonly IUnitOfWork _unitOfWork;

        public StorySetsSequenceService(IRepository<StorySetsSequence> storySetsSequenceRepository, IUnitOfWork unitOfWork)
        {
            _storySetsSequenceRepository = storySetsSequenceRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<StorySetsSequence>> ListAsync()
        {
            return await _storySetsSequenceRepository.ListAsync();
        }

        public async Task<StorySetsSequence> FindAsync(Guid id)
        {
            return await _storySetsSequenceRepository.FindAsync(id);
        }

        public async Task<Response<StorySetsSequence>> SaveAsync(StorySetsSequence storySetsSequence)
        {
            try
            {
                await _storySetsSequenceRepository.AddAsync(storySetsSequence);
                await _unitOfWork.SaveChangesAsync();
                return new Response<StorySetsSequence>(storySetsSequence);
            }
            catch(Exception exception)
            {
                return new Response<StorySetsSequence>(exception.Message);
            }
        }

        public async Task<Response<StorySetsSequence>> UpdateAsync(Guid id, StorySetsSequence storySetsSequence)
        {
            var existingSequence = await _storySetsSequenceRepository.FindAsync(id);

            if (existingSequence == null)
                return new Response<StorySetsSequence>($"Story sequence with ID '{id}' not found.");

            existingSequence.SetNumber = storySetsSequence.SetNumber;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySetsSequence>(existingSequence);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<StorySetsSequence>($"An error occurred when updating the sequence: {ex.Message}");
            }
        }

        public async Task<Response<StorySetsSequence>> DeleteAsync(Guid id)
        {
            var existingCategory = await _storySetsSequenceRepository.FindAsync(id);

            if (existingCategory == null)
                return new Response<StorySetsSequence>("Category not found.");

            try
            {
                _storySetsSequenceRepository.Remove(existingCategory);
                await _unitOfWork.SaveChangesAsync();

                return new Response<StorySetsSequence>(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<StorySetsSequence>($"An error occurred when deleting the category: {ex.Message}");
            }
        }
    }
}
