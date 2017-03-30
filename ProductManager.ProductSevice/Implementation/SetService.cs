namespace ProductManager.Services.Interfaces
{
    using Data;
    using Implementation;

    public class SetService : BaseService, ISetService
    {
        public SetService(IProductManagerData data)
            : base(data)
        {
        }
    }
}
