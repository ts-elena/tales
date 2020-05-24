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

    public class LineService : ILineService
    {
        private readonly ILineRepository _lineRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LineService(ILineRepository lineRepository, IUnitOfWork unitOfWork)
        {
            _lineRepository = lineRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Line>> ListAsync()
        {
            return await _lineRepository.ListAsync();
        }

        public async Task<Line> FindAsync(Guid id)
        {
            return await _lineRepository.FindAsync(id);
        }

        public async Task<Response<Line>> SaveAsync(Line line)
        {
            try
            {
                await _lineRepository.AddAsync(line);
                await _unitOfWork.SaveChangesAsync();
                return new Response<Line>(line);
            }
            catch (Exception exception)
            {
                return new Response<Line>($"The Line '{line.LineContent}' could not be saved. An error occured: {exception.Message}");
            }
        }

        public async Task<Response<Line>> UpdateAsync(Guid id, Line line)
        {
            var existingSequence = await _lineRepository.FindAsync(id);

            if (existingSequence == null)
                return new Response<Line>($"Line with id '{id}' was not found. Update operation failed.");

            existingSequence.StoryId = line.StoryId;
            existingSequence.LineContent = line.LineContent;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<Line>(existingSequence);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<Line>($"An error occurred when updating the Line with id '{id}': {ex.Message}");
            }
        }

        public async Task<Response<Line>> DeleteAsync(Guid id)
        {
            var existingCategory = await _lineRepository.FindAsync(id);

            if (existingCategory == null)
                return new Response<Line>($"Line with id '{id}' was not found. Delete operation failed.");

            try
            {
                _lineRepository.Remove(existingCategory);
                await _unitOfWork.SaveChangesAsync();

                return new Response<Line>(existingCategory);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<Line>($"An error occurred when deleting the Line with id '{id}': {ex.Message}");
            }
        }
    }
}
