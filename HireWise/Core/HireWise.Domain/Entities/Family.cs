using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class Family : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string FamilyType { get; set; }
        public string FamilyFirstName { get; set; }
        public string FamilyLastName { get; set; }
        public int FamilyPhoneNumber { get; set; }
        public Employee Employee { get; set; }
    }
}
