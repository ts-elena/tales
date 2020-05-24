using System.Collections.Generic;
using System.Threading.Tasks;
using TalesApp.Domain;

namespace aspdotnetcoreapp.Services.ServiceInterfaces
{
    public interface ILineService
    {
        Task<IEnumerable<Line>> ListAsync();
    }
}
