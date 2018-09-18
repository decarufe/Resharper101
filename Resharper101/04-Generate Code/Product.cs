using System;

namespace Resharper101
{
    public class Product : IIdentity
    {
        private readonly Guid _id;
        private readonly string _name;

        public Product(Guid id, string name)
        {
            _id = id;
            _name = name;
        }

        public Guid Id => _id;

        public string Name => _name;
    }
}