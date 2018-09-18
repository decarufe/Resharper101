using System;
using System.Collections.Generic;

namespace Resharper101
{
    public abstract class RepositoryDecorator<T> : IRepository<T> where T : IIdentity
    {
        private readonly IRepository<T> _repository;

        // Create a repository decorator
        protected RepositoryDecorator(IRepository<T> repository)
        {
            _repository = repository;
        }

        //TODO: Generate delegate implementation
    }
}