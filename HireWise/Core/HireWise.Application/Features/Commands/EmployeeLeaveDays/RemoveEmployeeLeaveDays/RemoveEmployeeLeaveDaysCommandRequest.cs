using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeLeaveDays.RemoveEmployeeLeaveDays
{
    public class RemoveEmployeeLeaveDaysCommandRequest : IRequest<RemoveEmployeeLeaveDaysCommandResponse>
    {
        public string EmployeeLeaveDaysId { get; set; }
    }
}
