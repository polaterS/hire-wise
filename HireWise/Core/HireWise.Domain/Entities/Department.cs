using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class Department : BaseEntity
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public ICollection<Position> Positions { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
