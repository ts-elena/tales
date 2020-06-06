namespace TalesAPI.Services
{
    using TalesAPI.Services.ServiceInterfaces;
    using TalesApp.Domain.Repositories;
    using TalesApp.Domain.Services;

    public class DictionaryWordService : IDictionaryWordService
    {
        private readonly IDictionaryWordRepository _dictionaryWordRepository;
        private readonly IUnitOfWork _unitOfWork;

        public DictionaryWordService(IDictionaryWordRepository dictionaryWordRepository, IUnitOfWork unitOfWork)
        {
            _dictionaryWordRepository = dictionaryWordRepository;
            _unitOfWork = unitOfWork;
        }
    }
}
