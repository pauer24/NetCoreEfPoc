using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CoreEfPoc.Context
{
    internal class DefaultDesignTimeDbContextFactory : IDesignTimeDbContextFactory<PocContext>
    {
        public PocContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PocContext>();

            optionsBuilder.UseSqlServer(Constants.ConnectionString);

            return new PocContext(optionsBuilder.Options);
        }
    }
}