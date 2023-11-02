using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class MaritalStatuWriteRepository : WriteRepository<MaritalStatu>, IMaritalStatuWriteRepository
    {
        public MaritalStatuWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
