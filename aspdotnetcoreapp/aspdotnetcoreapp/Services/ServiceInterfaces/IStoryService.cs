using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Domain;
using TalesApp.Domain.Services.Communication;

namespace TalesAPI.Services.ServiceInterfaces
{
    public interface IStoryService
    {
        Task<List<Story>> ActiveStoriesBySetId(Guid id);
        Task<Story> FindAsync(Guid id);
        Task<Response<Story>> SaveAsync(Story story);
        Task<Response<Story>> UpdateAsync(Guid id, Story story);
        Task<Response<Story>> DeleteAsync(Guid id);
    }
}
