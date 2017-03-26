namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using Data;
    using Models;

    internal interface IStorageService
    {
        IEnumerable<Storage> GetAll();
    }
}