using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class Language : BaseEntity
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
