using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireWise.Application.Dto
{
    public class EmployeeLeaveDaysDto
    {
        public string LeaveStartDate { get; set; }

        public string LeaveEndDate { get; set; }

        public string LeaveReason { get; set; }

        public string LeaveTypeName { get; set; }

        public string LeaveStatusName { get; set; }

        public string ApprovalComments { get; set; }
    }
}
