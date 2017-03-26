namespace ProductManager.ProductSevice
{
    using System.Collections.Generic;
    using System.Linq;
    using Data;
    using Data.Repositories;
    using Interfaces;
    using Models;

    class SetService : ISetService
    {
        private readonly IRepository<Set> setRepository;

        public SetService(IRepository<Set> setRepository)
        {
            this.setRepository = setRepository;
        }

        public IEnumerable<Set> GetAll()
        {
            return this.setRepository.GetAll().ToList();
        }
    }
}
