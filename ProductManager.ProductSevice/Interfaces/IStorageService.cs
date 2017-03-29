namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using Database;

    internal interface IStorageService
    {
        IEnumerable<Storage> GetAll();
    }
}