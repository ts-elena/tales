using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Domain;
using TalesApp.Domain.Services.Communication;

namespace aspdotnetcoreapp.Services.ServiceInterfaces
{
    public interface IStoryService
    {
        Task<IEnumerable<Story>> ListAsync();
        Task<Story> FindAsync(Guid id);
        Task<Response<Story>> SaveAsync(Story story);
        Task<Response<Story>> UpdateAsync(Guid id, Story story);
        Task<Response<Story>> DeleteAsync(Guid id);
    }
}
