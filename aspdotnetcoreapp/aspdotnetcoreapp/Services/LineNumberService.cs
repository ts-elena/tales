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

    public class LineNumberService : ILineNumberService
    {
        private readonly ILineNumberRepository _lineNumberRepository;
        private readonly IUnitOfWork _unitOfWork;

        public LineNumberService(ILineNumberRepository LineNumberNumberRepository, IUnitOfWork unitOfWork)
        {
            _lineNumberRepository = LineNumberNumberRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<LineNumber>> ListAsync()
        {
            return await _lineNumberRepository.ListAsync();
        }

        public async Task<LineNumber> FindAsync(Guid id)
        {
            return await _lineNumberRepository.FindAsync(id);
        }

        public async Task<Response<LineNumber>> SaveAsync(LineNumber lineNumber)
        {
            try
            {
                await _lineNumberRepository.AddAsync(lineNumber);
                await _unitOfWork.SaveChangesAsync();
                return new Response<LineNumber>(lineNumber);
            }
            catch (Exception exception)
            {
                return new Response<LineNumber>($"The line number with id '{lineNumber.LineId}' " +
                    $"could not be saved. An error occured: {exception.Message}");
            }
        }

        public async Task<Response<LineNumber>> UpdateAsync(Guid id, LineNumber lineNumber)
        {
            var existingLineNumber = await _lineNumberRepository.FindAsync(id);

            if (existingLineNumber == null)
                return new Response<LineNumber>($"Line Number with id '{id}' was not found. Update operation failed.");

            existingLineNumber.LineId = lineNumber.LineId;
            existingLineNumber.Number = lineNumber.Number;

            try
            {
                await _unitOfWork.SaveChangesAsync();

                return new Response<LineNumber>(existingLineNumber);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<LineNumber>($"An error occurred when updating the Line Number with id '{id}': {ex.Message}");
            }
        }

        public async Task<Response<LineNumber>> DeleteAsync(Guid id)
        {
            var existingLineNumber = await _lineNumberRepository.FindAsync(id);

            if (existingLineNumber == null)
                return new Response<LineNumber>($"LineNumber with id '{id}' was not found. Delete operation failed.");

            try
            {
                _lineNumberRepository.Remove(existingLineNumber);
                await _unitOfWork.SaveChangesAsync();

                return new Response<LineNumber>(existingLineNumber);
            }
            catch (Exception ex)
            {
                // Do some logging stuff
                return new Response<LineNumber>($"An error occurred when deleting the LineNumber with id '{id}': {ex.Message}");
            }
        }
    }
}
