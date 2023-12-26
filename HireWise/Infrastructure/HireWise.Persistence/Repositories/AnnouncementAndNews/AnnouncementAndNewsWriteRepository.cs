using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class AnnouncementAndNewsWriteRepository : WriteRepository<AnnouncementAndNews>, IAnnouncementAndNewsWriteRepository
    {
        public AnnouncementAndNewsWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
