using HireWise.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace HireWise.Persistence
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<HireWiseDbContext>
    {
        public HireWiseDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<HireWiseDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
