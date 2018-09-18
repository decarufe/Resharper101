using System;
using System.Collections.Generic;

namespace Resharper101
{
    public class RepositoryLogger<T> : RepositoryDecorator<T> where T : IIdentity
    {
        public RepositoryLogger(IRepository<T> repository) : base(repository)
        {
        }

        public override IEnumerable<T> GetAll()
        {
            Console.WriteLine("Get All");
            return base.GetAll();
        }

        public override T GetById(Guid id)
        {
            Console.WriteLine($"Get by id : {id}");
            return base.GetById(id);
        }

        public override void Save(T entity)
        {
            Console.WriteLine($"Save entity {entity.Id}");
            base.Save(entity);
        }
    }
}