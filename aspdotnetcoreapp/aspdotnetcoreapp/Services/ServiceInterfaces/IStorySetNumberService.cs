namespace aspdotnetcoreapp.Services
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Services.Communication;

    public interface IStorySetNumberService
    {
        Task<IEnumerable<StorySetNumber>> ListAsync();
        Task<StorySetNumber> FindAsync(Guid id);
        Task<Response<StorySetNumber>> UpdateAsync(Guid id, StorySetNumber storySetsSequence);
        Task<Response<StorySetNumber>> SaveAsync(StorySetNumber storySetsSequence);
        Task<Response<StorySetNumber>> DeleteAsync(Guid id);
    }
}
