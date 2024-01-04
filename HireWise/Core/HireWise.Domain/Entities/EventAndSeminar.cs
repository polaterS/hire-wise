using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class EventAndSeminar : BaseEntity
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string Description { get; set; }
    }
}
