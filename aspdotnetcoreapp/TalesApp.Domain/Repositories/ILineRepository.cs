namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineRepository: IRepository<Line>
    {
        Task<Line> LineByIdOrDefault(Guid id);
    }
}
