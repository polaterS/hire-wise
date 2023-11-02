using HireWise.Application;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class FileReadRepository : ReadRepository<HireWise.Domain.Entities.File>, IFileReadRepostiory
    {
        public FileReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
