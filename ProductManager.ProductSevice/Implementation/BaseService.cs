namespace ProductManager.Services.Implementation
{
    using Data;

    public abstract class BaseService
    {
        private IProductManagerData data;

        protected BaseService(IProductManagerData data)
        {
            this.data = data;
        }

        public IProductManagerData Data { get { return this.data; } }
    }
}
