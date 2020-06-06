using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Domain;
using TalesApp.Domain.Services.Communication;

namespace TalesAPI.Services.ServiceInterfaces
{
    public interface ILineService
    {
        Task<Line> LineByIdOrDefault(Guid id);
        Task<Response<IEnumerable<Line>>> SaveRangeAsync(IEnumerable<Line> line);
        Task<Response<IEnumerable<Line>>> UpdateRangeAsync(IEnumerable<Line> line);
        Task<Response<IEnumerable<Line>>> DeleteRangeAsync(IEnumerable<Guid> lineIds);
    }
}
