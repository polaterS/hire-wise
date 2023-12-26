using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class EventAndSeminar : BaseEntity
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
