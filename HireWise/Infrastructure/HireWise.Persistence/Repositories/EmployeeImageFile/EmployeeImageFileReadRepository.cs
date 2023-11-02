using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EmployeeImageFileReadRepository : ReadRepository<EmployeeImageFile>, IEmployeeImageFileReadRepository
    {
        public EmployeeImageFileReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
