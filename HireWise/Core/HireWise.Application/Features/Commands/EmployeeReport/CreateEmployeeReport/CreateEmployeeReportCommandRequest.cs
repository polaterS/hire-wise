using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeReport.CreateEmployeeReport
{
    public class CreateEmployeeReportCommandRequest : IRequest<CreateEmployeeReportCommandResponse>
    {
        public string Header { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Department { get; set; }
    }
}
