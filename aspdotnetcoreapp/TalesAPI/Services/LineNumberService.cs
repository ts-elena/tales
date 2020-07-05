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

    public class LineNumberService : ILineNumberService
    {
        private readonly ILineNumberRepository _lineNumberRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();
        
        public LineNumberService(ILineNumberRepository lineNumberRepository, IUnitOfWork unitOfWork)
        {
            _lineNumberRepository = lineNumberRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<LineNumber> LineNumbersOfStory(Guid storyId, int lineNumber)
        {
            return await _lineNumberRepository.LineNumbersOfStory(storyId, lineNumber);
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
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error updating line numbers: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<IEnumerable<LineNumber>>(
                    $"An error occurred when updating the Lines': {exception.Message}");
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
                _logger.Error(exception, $"Error saving line numbers: {exception.Message}. Inner exception: {exception.InnerException}");
                return new Response<IEnumerable<LineNumber>>(
                    $"New lines could not be saved. An error occured: {exception.Message}");
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
                _lineNumberRepository.RemoveRange(lineNumbersByIds);
                await _unitOfWork.SaveChangesAsync();

                return new Response<IEnumerable<LineNumber>>(lineNumbersByIds);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error updating line numbers by IDs: {exception.Message}. Inner exception: {exception.InnerException}");
                return new Response<IEnumerable<LineNumber>>(
                    $"An error occurred when deleting the Lines: {exception.Message}");
            }
        }
    }
}
