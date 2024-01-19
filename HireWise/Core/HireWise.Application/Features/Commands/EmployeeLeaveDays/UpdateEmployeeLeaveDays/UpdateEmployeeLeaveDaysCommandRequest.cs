using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeLeaveDays.UpdateEmployeeLeaveDays
{
    public class UpdateEmployeeLeaveDaysCommandRequest : IRequest<UpdateEmployeeLeaveDaysCommandResponse>
    {
        public string EmployeeLeaveDaysId { get; set; }
        public int EmployeeId { get; set; }

        public string LeaveStartDate { get; set; }

        public string LeaveEndDate { get; set; }

        public string LeaveReason { get; set; }

        public string LeaveTypeName { get; set; }

        public string LeaveStatusName { get; set; }

        public string ApprovalComments { get; set; }
    }
}
