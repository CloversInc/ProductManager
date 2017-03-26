namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using Data;

    internal interface IStorageService
    {
        IEnumerable<Storage> GetAll();
    }
}