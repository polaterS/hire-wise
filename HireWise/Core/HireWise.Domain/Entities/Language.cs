using HireWise.Domain.Entities.Common;
using HireWise.Domain.Enums;

namespace HireWise.Domain.Entities
{
    public class Language : BaseEntity
    {
        public int EmployeeId { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
