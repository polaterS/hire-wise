using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeReport.GetByIdEmployeeReport
{
    public class GetByIdEmployeeReportQueryHandler : IRequestHandler<GetByIdEmployeeReportQueryRequest, GetByIdEmployeeReportQueryResponse>
    {
        IEmployeeReportReadRepository _employeeReportReadRepository;

        public GetByIdEmployeeReportQueryHandler(IEmployeeReportReadRepository employeeReportReadRepository)
        {
            _employeeReportReadRepository = employeeReportReadRepository;
        }

        public async Task<GetByIdEmployeeReportQueryResponse> Handle(GetByIdEmployeeReportQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.EmployeeReport employeeReport = await _employeeReportReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Header = employeeReport.Header,
                Subject = employeeReport.Subject,
                Content = employeeReport.Content,
                Department = employeeReport.Department,
            };
        }
    }
}
