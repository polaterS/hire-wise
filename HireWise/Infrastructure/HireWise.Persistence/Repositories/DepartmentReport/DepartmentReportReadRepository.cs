using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class DepartmentReportReadRepository : ReadRepository<DepartmentReport>, IDepartmentReportReadRepository
    {
        public DepartmentReportReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
