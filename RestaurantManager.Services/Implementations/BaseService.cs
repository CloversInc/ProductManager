namespace RestaurantManager.Services.Implementations
{
    using BindingViewModels.Mapper;
    using Data;
    using Interfaces;

    public abstract class BaseService
    {
        private IRestaurantManagerData data;
        private IMappingService mappingService;

        protected BaseService(IRestaurantManagerData data, IMappingService mappingService)
        {
            this.data = data;
            this.mappingService = mappingService;
        }

        public IRestaurantManagerData Data { get { return this.data; } }

        public IMappingService MappingService { get { return this.mappingService; } }
    }
}
