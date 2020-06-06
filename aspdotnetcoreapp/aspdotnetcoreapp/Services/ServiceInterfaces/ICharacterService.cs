using System;

namespace TalesAPI.Services.ServiceInterfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using TalesApp.Domain;
    using TalesApp.Domain.Services.Communication;

    public interface ICharacterService
    {
        Task<Character> FindAsync(Guid id);
        Task<Response<IEnumerable<Character>>> SaveRangeAsync(List<Character> character);
        Task<Response<IEnumerable<Character>>> UpdateRangeAsync(List<Character> charactersToUpdate);
        Task<Response<IEnumerable<Character>>> DeleteAsync(List<Character> charactersToDelete);
    }
}
