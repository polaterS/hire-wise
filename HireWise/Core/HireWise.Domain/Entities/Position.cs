using HireWise.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireWise.Domain.Entities
{
    public class Position : BaseEntity
    {
        public string Name { get; set; } 
        public ICollection<Employee> Employees { get; set; }
        public ICollection<Department> Departments { get; set; }
    }
}