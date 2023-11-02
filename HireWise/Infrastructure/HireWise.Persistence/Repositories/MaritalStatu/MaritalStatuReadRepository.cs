using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class MaritalStatuReadRepository : ReadRepository<MaritalStatu>, IMaritalStatuReadRepository
    {
        public MaritalStatuReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
