using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EmployeeLeaveDaysReadRepository : ReadRepository<EmployeeLeaveDays>, IEmployeeLeaveDaysReadRepository
    {
        public EmployeeLeaveDaysReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
