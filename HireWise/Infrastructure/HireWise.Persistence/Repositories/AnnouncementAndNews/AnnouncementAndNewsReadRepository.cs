using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class AnnouncementAndNewsReadRepository : ReadRepository<AnnouncementAndNews>, IAnnouncementAndNewsReadRepository
    {
        public AnnouncementAndNewsReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
