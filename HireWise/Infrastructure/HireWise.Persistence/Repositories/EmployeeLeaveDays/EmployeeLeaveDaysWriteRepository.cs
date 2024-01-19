using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EmployeeLeaveDaysWriteRepository : WriteRepository<EmployeeLeaveDays>, IEmployeeLeaveDaysWriteRepository
    {
        public EmployeeLeaveDaysWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
