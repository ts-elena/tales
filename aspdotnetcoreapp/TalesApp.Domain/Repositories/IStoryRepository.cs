namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IStoryRepository
    {
        Task<List<Story>> ActiveStoriesBySetId(Guid setId);
        Task<Story> FindAsync(Guid id);
        void Update(Story dbObject);
        Task AddAsync(Story dbObject);
        void Remove(Story dbObject);
    }
}
