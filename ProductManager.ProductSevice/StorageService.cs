namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Repositories;
    using Models;

    class StorageService : IStorageService
    {
        private readonly IRepository<Storage> storageRepository;

        public StorageService(IRepository<Storage> storageRepository)
        {
            this.storageRepository = storageRepository;
        }

        public IEnumerable<Storage> GetAll()
        {
            return this.storageRepository.GetAll().ToList();
        }
    }
}
