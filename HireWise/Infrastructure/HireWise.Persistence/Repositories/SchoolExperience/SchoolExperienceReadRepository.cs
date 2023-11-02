using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class SchoolExperienceReadRepository : ReadRepository<SchoolExperience>, ISchoolExperienceReadRepository
    {
        public SchoolExperienceReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
