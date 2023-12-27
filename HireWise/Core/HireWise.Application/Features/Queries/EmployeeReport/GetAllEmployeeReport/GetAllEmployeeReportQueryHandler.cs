using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeReport.GetAllEmployeeReport
{
    public class GetAllEmployeeReportQueryHandler : IRequestHandler<GetAllEmployeeReportQueryRequest, GetAllEmployeeReportQueryResponse>
    {
        IEmployeeReportReadRepository _employeeReportReadRepository;

        public GetAllEmployeeReportQueryHandler(IEmployeeReportReadRepository employeeReportReadRepository)
        {
            _employeeReportReadRepository = employeeReportReadRepository;
        }

        public async Task<GetAllEmployeeReportQueryResponse> Handle(GetAllEmployeeReportQueryRequest request, CancellationToken cancellationToken)
        {
            var totalEmployeeReportCount = _employeeReportReadRepository.GetAll(false).Count();
            var employeeReports = _employeeReportReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
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
                EmployeeReports = employeeReports,
                TotalEmployeeReportCount = totalEmployeeReportCount
            };
        }
    }
}
