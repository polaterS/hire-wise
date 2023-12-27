using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class DepartmentReportWriteRepository : WriteRepository<DepartmentReport>, IDepartmentReportWriteRepository
    {
        public DepartmentReportWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
