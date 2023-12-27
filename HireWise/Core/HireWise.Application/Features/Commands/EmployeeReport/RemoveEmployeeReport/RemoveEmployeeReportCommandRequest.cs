using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeReport.RemoveEmployeeReport
{
    public class RemoveEmployeeReportCommandRequest : IRequest<RemoveEmployeeReportCommandResponse>
    {
        public string Id { get; set; }
    }
}
