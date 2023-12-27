using MediatR;

namespace HireWise.Application.Features.Commands.DepartmentReport.CreateDepartmentReport
{
    public class CreateDepartmentReportCommandRequest : IRequest<CreateDepartmentReportCommandResponse>
    {
        public string Header { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Department { get; set; }
    }
}
