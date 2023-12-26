using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EventAndSeminarWriteRepository : WriteRepository<EventAndSeminar>, IEventAndSeminarWriteRepository
    {
        public EventAndSeminarWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
