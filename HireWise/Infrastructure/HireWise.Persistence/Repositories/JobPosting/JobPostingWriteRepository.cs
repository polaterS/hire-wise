using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class JobPostingWriteRepository : WriteRepository<JobPosting>, IJobPostingWriteRepository
    {
        public JobPostingWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
