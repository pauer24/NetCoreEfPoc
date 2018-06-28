using System;

namespace CoreEfPoc.Entities
{
    internal class Child : BaseEntity
    {
        public int Count { get; set; }

        public string Name { get; set; }

        public virtual Parent Parent { get; set; }

        public Guid? ParentId { get; set; }
    }
}