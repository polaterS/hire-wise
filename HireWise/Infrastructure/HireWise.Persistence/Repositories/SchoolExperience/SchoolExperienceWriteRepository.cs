using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class SchoolExperienceWriteRepository : WriteRepository<SchoolExperience>, ISchoolExperienceWriteRepository
    {
        public SchoolExperienceWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
