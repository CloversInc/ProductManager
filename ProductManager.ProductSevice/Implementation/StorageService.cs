namespace ProductManager.Services.Implementation
{
    using Data;
    using Interfaces;

    public class StorageServices : BaseService, IStorageService
    {
        public StorageServices(IProductManagerData data)
            : base(data)
        {
        }
    }
}
