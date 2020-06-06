namespace TalesAPI.Services.ServiceInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Services.Communication;

    public interface IStorySetService
    {
        Task<IEnumerable<StorySet>> ListAsync();
        Task<StorySet> FindAsync(Guid id);
        Task<Response<StorySet>> SaveAsync(StorySet storySetsSequence);
        Task<Response<StorySet>> UpdateAsync(StorySet storySetsSequence);
        Task<Response<StorySet>> DeleteAsync(Guid id);
    }
}
