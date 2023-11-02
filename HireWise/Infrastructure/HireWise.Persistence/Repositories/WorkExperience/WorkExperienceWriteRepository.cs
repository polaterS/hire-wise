using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class WorkExperienceWriteRepository : WriteRepository<WorkExperience>, IWorkExperienceWriteRepository
    {
        public WorkExperienceWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
