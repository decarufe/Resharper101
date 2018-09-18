using System;
using System.Collections.Generic;
using System.Linq;

namespace Resharper101
{
    public class Repository<T> : IRepository<T> where T : IIdentity
    {
        private readonly List<T> _itemList = new List<T>();

        public IEnumerable<T> GetAll()
        {
            return _itemList;
        }

        public T GetById(Guid id)
        {
            return _itemList.SingleOrDefault(p => p.Id == id);
        }
        public void Save(T entity)
        {
            var product = _itemList.SingleOrDefault(p => p.Id == entity.Id);
            if (product == null)
            {
                _itemList.Add(entity);
            }
            else
            {
                _itemList[_itemList.IndexOf(product)] = entity;
            }
        }

    }
}