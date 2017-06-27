using RestaurantManager.Data;

namespace RestaurantManager.Services.Implementations
{
    public abstract class BaseService
    {
        private IRestaurantManagerData data;

        protected BaseService(IRestaurantManagerData data)
        {
            this.data = data;
        }

        public IRestaurantManagerData Data { get { return this.data; } }
    }
}
