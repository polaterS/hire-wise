using MediatR;

namespace HireWise.Application.Features.Commands.DepartmentReport.UpdateDepartmentReport
{
    public class UpdateDepartmentReportCommandRequest : IRequest<UpdateDepartmentReportCommandResponse>
    {
        public string Id { get; set; }
        public string Header { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Department { get; set; }
    }
}
