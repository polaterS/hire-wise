using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeReport.GetAllEmployeeReport
{
    public class GetAllEmployeeReportQueryRequest : IRequest<GetAllEmployeeReportQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
