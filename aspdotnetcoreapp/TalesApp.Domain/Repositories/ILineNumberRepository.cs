namespace TalesApp.Domain.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface ILineNumberRepository: IRepository<LineNumber>
    {
        Task<LineNumber> LineNumberById(Guid id);
        Task<LineNumber> LineNumbersOfStory(Guid id, int lineNumber);
    }
}
