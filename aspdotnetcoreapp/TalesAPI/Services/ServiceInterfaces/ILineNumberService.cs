namespace TalesAPI.Services.ServiceInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Services.Communication;

    public interface ILineNumberService
    {
        Task<LineNumber> LineNumbersOfStory(Guid storyId, int lineNumber);
        Task<Response<IEnumerable<LineNumber>>> UpdateRangeAsync(List<LineNumber> lineNumbers);
        Task<Response<IEnumerable<LineNumber>>> AddRangeAsync(List<LineNumber> lineNumbers);
        Task<Response<IEnumerable<LineNumber>>> DeleteRangeByLineId(IEnumerable<Guid> lineNumberIds);
    }
}
