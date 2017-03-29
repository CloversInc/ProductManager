namespace ProductManager.ProductSevice.Interfaces
{
    using System.Collections.Generic;
    using Database;

    interface ISetService
    {
        IEnumerable<Set> GetAll();
    }
}
