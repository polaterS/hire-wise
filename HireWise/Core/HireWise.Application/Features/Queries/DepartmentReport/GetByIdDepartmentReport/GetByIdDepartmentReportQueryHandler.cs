using MediatR;

namespace HireWise.Application.Features.Queries.DepartmentReport.GetByIdDepartmentReport
{
    public class GetByIdDepartmentReportQueryHandler : IRequestHandler<GetByIdDepartmentReportQueryRequest, GetByIdDepartmentReportQueryResponse>
    {
        IDepartmentReportReadRepository _departmentReportReadRepository;

        public GetByIdDepartmentReportQueryHandler(IDepartmentReportReadRepository departmentReportReadRepository)
        {
            _departmentReportReadRepository = departmentReportReadRepository;
        }

        public async Task<GetByIdDepartmentReportQueryResponse> Handle(GetByIdDepartmentReportQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.DepartmentReport departmentReport = await _departmentReportReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Header = departmentReport.Header,
                Subject = departmentReport.Subject,
                Content = departmentReport.Content,
                Department = departmentReport.Department,
            };
        }
    }
}
