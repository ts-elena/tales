namespace TalesAPI.Services
{
    using ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using TalesApp.Domain.Services.Communication;

    public class LineNumberService : ILineNumberService
    {
        private readonly ILineNumberRepository _lineNumberRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LineNumberService(ILineNumberRepository lineNumberRepository, IUnitOfWork unitOfWork)
        {
            _lineNumberRepository = lineNumberRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<LineNumber>> LineNumbersOfStory(Guid storyId)
        {
            return await _lineNumberRepository.LineNumbersOfStory(storyId);
        }

        public async Task<Response<IEnumerable<LineNumber>>> UpdateRangeAsync(List<LineNumber> lineNumbers)
        {
            foreach (var lineNumber in lineNumbers)
            {
                LineNumber number = await _lineNumberRepository.LineNumberById(lineNumber.LineId);

                if (number == null)
                    return new Response<IEnumerable<LineNumber>>(
                        $"Line with id '{lineNumber.LineId}' was not found. Update operation failed.");

                number.StoryId = lineNumber.StoryId;
                number.Number = lineNumber.Number;
            }

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<IEnumerable<LineNumber>>(lineNumbers);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<IEnumerable<LineNumber>>(
                    $"An error occurred when updating the Lines': {ex.Message}");
            }
        }

        public async Task<Response<IEnumerable<LineNumber>>> AddRangeAsync(List<LineNumber> lineNumbers)
        {
            try
            {
                await _lineNumberRepository.AddRangeAsync(lineNumbers);
                await _unitOfWork.SaveChangesAsync();
                return new Response<IEnumerable<LineNumber>>(lineNumbers);
            }
            catch (Exception exception)
            {
                return new Response<IEnumerable<LineNumber>>(
                    $"New lines could not be saved. An error occured: {exception.Message}");
            }
        }

        public async Task<Response<IEnumerable<LineNumber>>> DeleteRangeByStoryId(Guid storyId)
        {
            List<LineNumber> lineNumbersByStoryId = await _lineNumberRepository.LineNumbersOfStory(storyId);

            if (lineNumbersByStoryId == null)
                return new Response<IEnumerable<LineNumber>>(
                    $"Line for story with id '{storyId}' were not found. Delete operation failed.");

            try
            {
                _lineNumberRepository.DeleteRange(lineNumbersByStoryId);
                await _unitOfWork.SaveChangesAsync();

                return new Response<IEnumerable<LineNumber>>(lineNumbersByStoryId);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<IEnumerable<LineNumber>>(
                    $"An error occurred when deleting the Lines: {ex.Message}");
            }
        }

        public async Task<Response<IEnumerable<LineNumber>>> DeleteRangeByLineId(IEnumerable<Guid> lineIds)
        {
            var lineNumbersByIds = new List<LineNumber>();
            foreach (var lineId in lineIds)
            {
                var lineNumbersByStoryId = await _lineNumberRepository.LineNumberById(lineId);

                if (lineNumbersByStoryId == null)
                    return new Response<IEnumerable<LineNumber>>(
                        $"Line with id '{lineId}' was not found. Delete operation failed.");
                lineNumbersByIds.Add(lineNumbersByStoryId);
            }

            try
            {
                _lineNumberRepository.DeleteRange(lineNumbersByIds);
                await _unitOfWork.SaveChangesAsync();

                return new Response<IEnumerable<LineNumber>>(lineNumbersByIds);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<IEnumerable<LineNumber>>(
                    $"An error occurred when deleting the Lines: {ex.Message}");
            }
        }
    }
}
