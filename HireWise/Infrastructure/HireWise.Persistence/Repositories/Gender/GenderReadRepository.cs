using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class GenderReadRepository : ReadRepository<Gender>, IGenderReadRepository
    {
        public GenderReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
