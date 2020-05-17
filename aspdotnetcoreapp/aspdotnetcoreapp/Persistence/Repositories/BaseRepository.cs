using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalesApp.Data;

namespace aspdotnetcoreapp.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly TalesContext _context;

        public BaseRepository(TalesContext context)
        {
            _context = context;
        }
    }
}
