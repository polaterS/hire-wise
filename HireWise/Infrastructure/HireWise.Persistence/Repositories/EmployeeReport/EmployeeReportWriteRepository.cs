using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EmployeeReportWriteRepository : WriteRepository<EmployeeReport>, IEmployeeReportWriteRepository
    {
        public EmployeeReportWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
