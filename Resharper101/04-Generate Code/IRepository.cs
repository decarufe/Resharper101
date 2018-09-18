using System;
using System.Collections.Generic;

namespace Resharper101
{
    public interface IRepository<T> where T : IIdentity
    {
        IEnumerable<T> GetAll();
        T GetById(Guid id);
        void Save(T entity);
    }
}