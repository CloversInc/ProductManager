namespace ProductManager.ProductSevice.Interfaces
{
    using System.Collections.Generic;
    using Data;

    interface ISetService
    {
        IEnumerable<Set> GetAll();
    }
}
