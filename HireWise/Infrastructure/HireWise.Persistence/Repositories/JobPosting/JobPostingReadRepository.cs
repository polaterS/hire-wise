using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class JobPostingReadRepository : ReadRepository<JobPosting>, IJobPostingReadRepository
    {
        public JobPostingReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
