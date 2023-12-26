using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class Position : BaseEntity
    {
        public string Name { get; set; } 
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}