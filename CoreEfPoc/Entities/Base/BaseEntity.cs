using System;

namespace CoreEfPoc.Entities
{
    internal abstract class BaseEntity
    {
        public Guid Id { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}