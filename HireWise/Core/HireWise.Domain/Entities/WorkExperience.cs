using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class WorkExperience : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Departmant { get; set; }
        public string Position { get; set; }
        public string WorkDateOfStart { get; set; }
        public string WorkDateOfEnd { get; set; }
        public Employee Employee { get; set; }
    }
}
