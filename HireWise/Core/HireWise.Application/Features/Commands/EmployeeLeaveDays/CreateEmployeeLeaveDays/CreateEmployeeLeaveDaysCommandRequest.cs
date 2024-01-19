using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeLeaveDays.CreateEmployeeLeaveDays
{
    public class CreateEmployeeLeaveDaysCommandRequest : IRequest<CreateEmployeeLeaveDaysCommandResponse>
    {
        public int EmployeeId { get; set; }

        public string LeaveStartDate { get; set; }

        public string LeaveEndDate { get; set; }

        public string LeaveReason { get; set; }

        public string LeaveTypeName { get; set; }

        public string LeaveStatusName { get; set; }

        public string ApprovalComments { get; set; }
    }
}
