using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EmployeeImageFileWriteRepository : WriteRepository<EmployeeImageFile>, IEmployeeImageFileWriteRepository
    {
        public EmployeeImageFileWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
