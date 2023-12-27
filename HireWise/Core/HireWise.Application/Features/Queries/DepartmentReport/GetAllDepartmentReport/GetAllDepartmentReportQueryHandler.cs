using MediatR;

namespace HireWise.Application.Features.Queries.DepartmentReport.GetAllDepartmentReport
{
    public class GetAllDepartmentReportQueryHandler : IRequestHandler<GetAllDepartmentReportQueryRequest, GetAllDepartmentReportQueryResponse>
    {
        IDepartmentReportReadRepository _departmentReportReadRepository;

        public GetAllDepartmentReportQueryHandler(IDepartmentReportReadRepository departmentReportReadRepository)
        {
            _departmentReportReadRepository = departmentReportReadRepository;
        }

        public async Task<GetAllDepartmentReportQueryResponse> Handle(GetAllDepartmentReportQueryRequest request, CancellationToken cancellationToken)
        {
            var totalDepartmentReportCount = _departmentReportReadRepository.GetAll(false).Count();
            var departmentReports = _departmentReportReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.Header,
                d.Subject,
                d.Content,
                d.Department
            }).ToList();

            return new()
            {
                DepartmentReports = departmentReports,
                TotalDepartmentReportCount = totalDepartmentReportCount
            };
        }
    }
}
