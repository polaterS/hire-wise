using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class WorkExperienceReadRepository : ReadRepository<WorkExperience>, IWorkExperienceReadRepository
    {
        public WorkExperienceReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
