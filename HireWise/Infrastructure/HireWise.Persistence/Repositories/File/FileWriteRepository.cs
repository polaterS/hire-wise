using HireWise.Application;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class FileWriteRepository : WriteRepository<HireWise.Domain.Entities.File>, IFileWriteRepostiory
    {
        public FileWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
