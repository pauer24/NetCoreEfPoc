using CoreEfPoc.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreEfPoc.Context
{
    internal class PocContext : DbContext
    {
        public PocContext(DbContextOptions<PocContext> options) : base(options)
        {
        }

        public DbSet<Parent> Parents { get; set; }

        public DbSet<Child> Children { get; set; }

        public static PocContext Build()
        {
            var optionsBuilder = new DbContextOptionsBuilder<PocContext>();
            optionsBuilder.UseSqlServer(Constants.ConnectionString);

            return new PocContext(optionsBuilder.Options);
        }
    }
}