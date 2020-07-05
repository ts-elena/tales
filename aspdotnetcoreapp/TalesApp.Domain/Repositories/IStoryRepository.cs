namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStoryRepository: IRepository<Story>
    {
        Task<List<Story>> StoriesBySetId(Guid setId);
    }
}
