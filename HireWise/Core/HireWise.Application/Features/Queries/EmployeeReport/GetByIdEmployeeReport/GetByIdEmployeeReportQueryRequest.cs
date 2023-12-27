using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeReport.GetByIdEmployeeReport
{
    public class GetByIdEmployeeReportQueryRequest : IRequest<GetByIdEmployeeReportQueryResponse>
    {
        public string Id { get; set; }
    }
}
