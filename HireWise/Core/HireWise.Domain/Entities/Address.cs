using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Title { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public Employee Employee { get; set; }
    }
}
