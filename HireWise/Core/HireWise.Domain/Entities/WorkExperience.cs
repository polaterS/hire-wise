using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class WorkExperience : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Departmant { get; set; }
        public string Position { get; set; }
        public DateTime WorkDateOfStart { get; set; }
        public DateTime? WorkDateOfEnd { get; set; }
        public Employee Employee { get; set; }
    }
}
