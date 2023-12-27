using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeReport.RemoveEmployeeReport
{
    public class RemoveEmployeeReportCommandHandler : IRequestHandler<RemoveEmployeeReportCommandRequest, RemoveEmployeeReportCommandResponse>
    {
        IEmployeeReportWriteRepository _employeeReportWriteRepository;

        public RemoveEmployeeReportCommandHandler(IEmployeeReportWriteRepository employeeReportWriteRepository)
        {
            _employeeReportWriteRepository = employeeReportWriteRepository;
        }

        public async Task<RemoveEmployeeReportCommandResponse> Handle(RemoveEmployeeReportCommandRequest request, CancellationToken cancellationToken)
        {
            await _employeeReportWriteRepository.RemoveAsync(request.Id);
            await _employeeReportWriteRepository.SaveAsync();
            return new();
        }
    }
}
