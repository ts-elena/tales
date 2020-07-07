namespace TalesAPI.Services
{
    using TalesAPI.Persistence;
    using TalesAPI.Services.ServiceInterfaces;
    using TalesApp.Domain;
    using TalesApp.Domain.Repositories;

    public class DictionaryWordService : IDictionaryWordService
    {
        private readonly IRepository<DictionaryWord> _dictionaryWordRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DictionaryWordService(IRepository<DictionaryWord> dictionaryWordRepository, IUnitOfWork unitOfWork)
        {
            _dictionaryWordRepository = dictionaryWordRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
