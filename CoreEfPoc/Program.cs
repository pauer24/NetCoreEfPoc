using CoreEfPoc.Context;
using CoreEfPoc.Entities;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreEfPoc
{
    internal class Program
    {
        private static PocContext _context;

        public static async Task Main(string[] args)
        {
            var _context = PocContext.Build();
            await CleanDb(_context);

            var parent = Parent(1);

            var children = Indexes(2).Select(i => Child(i, parent: parent));

            //_context.Parents.Add(parent);
            _context.Children.AddRange(children);
            await _context.SaveChangesAsync();

            Console.WriteLine("Hello World!");
        }

        private static Parent Parent(int count, string name = "default")
        {
            return new Parent
            {
                Num = count,
                Name = name
            };
        }

        private static Child Child(int count, string name = "default child", Parent parent = null)
        {
            return new Child
            {
                Count = count,
                Name = name,
                Parent = parent,
                ParentId = parent?.Id
            };
        }

        private static async Task CleanDb(PocContext _context)
        {
            _context.Children.ToList().ForEach(c => _context.Children.Remove(c));
            _context.Parents.ToList().ForEach(p => _context.Parents.Remove(p));
            await _context.SaveChangesAsync();
        }

        private static int[] Indexes(int count, int start = 0)
        {
            var result = new int[count];

            var index = 0;
            while (count-- > 0)
            {
                result[index] = start++;
                index++;
            }

            return result;
        }
    }
}