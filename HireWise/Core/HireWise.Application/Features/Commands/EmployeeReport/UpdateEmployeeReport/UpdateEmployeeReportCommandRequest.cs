using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeReport.UpdateEmployeeReport
{
    public class UpdateEmployeeReportCommandRequest : IRequest<UpdateEmployeeReportCommandResponse>
    {
        public string Id { get; set; }
        public string Header { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Department { get; set; }
    }
}
