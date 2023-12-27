using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeReport.UpdateEmployeeReport
{
    public class UpdateEmployeeReportCommandHandler : IRequestHandler<UpdateEmployeeReportCommandRequest, UpdateEmployeeReportCommandResponse>
    {
        IEmployeeReportWriteRepository _employeeReportWriteRepository;
        IEmployeeReportReadRepository _employeeReportReadRepository;

        public UpdateEmployeeReportCommandHandler(IEmployeeReportWriteRepository employeeReportWriteRepository, IEmployeeReportReadRepository employeeReportReadRepository)
        {
            _employeeReportWriteRepository = employeeReportWriteRepository;
            _employeeReportReadRepository = employeeReportReadRepository;
        }

        public async Task<UpdateEmployeeReportCommandResponse> Handle(UpdateEmployeeReportCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.EmployeeReport departmentReport = await _employeeReportReadRepository.GetByIdAsync(request.Id);
            departmentReport.Header = request.Header;
            departmentReport.Subject = request.Subject;
            departmentReport.Content = request.Content;
            departmentReport.Department = request.Department;
            await _employeeReportWriteRepository.SaveAsync();
            return new();
        }
    }
}
