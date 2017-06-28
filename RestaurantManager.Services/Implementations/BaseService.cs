using RestaurantManager.Data;
using RestaurantManager.Services.Configurations;

namespace RestaurantManager.Services.Implementations
{
    public abstract class BaseService
    {
        private IRestaurantManagerData data;

        protected BaseService(IRestaurantManagerData data)
        {
            this.data = data;
            MapperConfig.Initilize();
        }

        public IRestaurantManagerData Data { get { return this.data; } }
    }
}
