using MediatR;

namespace HireWise.Application.Features.Queries.DepartmentReport.GetByIdDepartmentReport
{
    public class GetByIdDepartmentReportQueryRequest : IRequest<GetByIdDepartmentReportQueryResponse>
    {
        public string Id { get; set; }
    }
}
