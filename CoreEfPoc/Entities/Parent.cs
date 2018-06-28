using System.Collections.Generic;

namespace CoreEfPoc.Entities
{
    internal class Parent : BaseEntity
    {
        public string Name { get; set; }
        public int Num { get; set; }

        public IEnumerable<Child> Children { get; set; }
    }
}