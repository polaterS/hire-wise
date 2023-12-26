using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EventAndSeminarReadRepository : ReadRepository<EventAndSeminar>, IEventAndSeminarReadRepository
    {
        public EventAndSeminarReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
