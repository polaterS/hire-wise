using MediatR;

namespace HireWise.Application.Features.Queries.DepartmentReport.GetAllDepartmentReport
{
    public class GetAllDepartmentReportQueryRequest : IRequest<GetAllDepartmentReportQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
