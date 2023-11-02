using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class FamilyReadRepository : ReadRepository<Family>, IFamilyReadRepository
    {
        public FamilyReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
