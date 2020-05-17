using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalesApp.Domain;
using TalesApp.Domain.Services.Communication;

namespace aspdotnetcoreapp.Services
{
    public interface IService<T>
    {
        Task<IEnumerable<T>> ListAsync();
        Task<T> FindAsync(Guid id);
        Task<Response<StorySetsSequence>> UpdateAsync(Guid id, T storySetsSequence);
        Task<Response<StorySetsSequence>> SaveAsync(T storySetsSequence);
        Task<Response<StorySetsSequence>> DeleteAsync(Guid id);
    }
}
