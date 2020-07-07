namespace TalesAPI.Services
{
    using NLog;
    using ServiceInterfaces;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TalesAPI.Persistence;
    using TalesAPI.Persistence.Repositories;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;
    using TalesApp.Domain.Services.Communication;

    public class LineService : ILineService
    {
        private readonly ILineRepository _lineRepository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly Logger _logger = LogManager.GetCurrentClassLogger();

        public LineService(IUnitOfWork unitOfWork)
        {
            _lineRepository = unitOfWork.Line;
            _unitOfWork = unitOfWork;
        }

        public async Task<Line> LineByIdOrDefault(Guid id)
        {
            return await _lineRepository.LineByIdOrDefault(id);
        }

        public async Task<Response<IEnumerable<Line>>> SaveRangeAsync(IEnumerable<Line> lines)
        {
            try
            {
                List<Line> dBObject = lines.ToList();
                await _lineRepository.AddRangeAsync(dBObject);
                await _unitOfWork.Complete();
                return new Response<IEnumerable<Line>>(dBObject);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error saving new Lines: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<IEnumerable<Line>>($"The Lines could not be saved. An error occured: {exception.Message}");
            }
        }

        public async Task<Response<IEnumerable<Line>>> UpdateRangeAsync(IEnumerable<Line> lines)
        {
            List<Line> dBObject = lines.ToList();
            foreach (var line in dBObject)
            {
                Line existingLine = await _lineRepository.LineByIdOrDefault(line.LineId);

                if (existingLine == null)
                    return new Response<IEnumerable<Line>>($"Line with id '{line.LineId}' was not found. Update operation failed.");

                existingLine.StoryId = line.StoryId;
                existingLine.LineContent = line.LineContent;
            }

            try
            {
                await _unitOfWork.Complete();

                return new Response<IEnumerable<Line>>(dBObject);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error updating Lines: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<IEnumerable<Line>>($"An error occurred when updating the Lines': {exception.Message}");
            }
        }

        public async Task<Response<IEnumerable<Line>>> DeleteRangeAsync(IEnumerable<Guid> lineIds)
        {
            List<Line> linesById = new List<Line>() { };
            foreach (Guid lineId in lineIds)
            {
                Line lineById = await _lineRepository.LineByIdOrDefault(lineId);

                if (lineById == null)
                    return new Response<IEnumerable<Line>>($"Line with id '{lineId}' was not found. Delete operation failed.");
                linesById.Add(lineById);
            }

            try
            {
                _lineRepository.RemoveRange(linesById);
                await _unitOfWork.Complete();

                return new Response<IEnumerable<Line>>(linesById);
            }
            catch (Exception exception)
            {
                _logger.Error(exception, $"Error updating Lines: {exception.Message}. Inner exception: '{exception.InnerException}'");
                return new Response<IEnumerable<Line>>($"An error occurred when deleting the Lines: {exception.Message}");
            }
        }
    }
}
