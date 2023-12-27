using MediatR;

namespace HireWise.Application.Features.Commands.DepartmentReport.RemoveDepartmentReport
{
    public class RemoveDepartmentReportCommandRequest : IRequest<RemoveDepartmentReportCommandResponse>
    {
        public string Id { get; set; }
    }
}
