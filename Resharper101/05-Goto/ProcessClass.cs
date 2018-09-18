using System;

namespace Resharper101
{
    public class ProcessClass
    {
        //TODO: Show navigation
        private readonly IRepository<Product> _repository;

        public ProcessClass()
        {
            _repository = new Repository<Product>();
            _repository = new RepositoryLogger<Product>(_repository);
        }

        public void Initialise()
        {
            _repository.Save(new Product(Guid.NewGuid(), "Product 1"));
            _repository.Save(new Product(Guid.NewGuid(), "Product 2"));
            _repository.Save(new Product(Guid.NewGuid(), "Product 3"));
            _repository.Save(new Product(Guid.NewGuid(), "Product 4"));
        }
    }
}