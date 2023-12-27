using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class DepartmentReport : BaseEntity
    {
        public string Header { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Department { get; set; }
    }
}
