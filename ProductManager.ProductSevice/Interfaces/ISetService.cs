namespace ProductManager.ProductSevice.Interfaces
{
    using System.Collections.Generic;
    using Data;
    using Models;

    interface ISetService
    {
        IEnumerable<Set> GetAll();
    }
}
