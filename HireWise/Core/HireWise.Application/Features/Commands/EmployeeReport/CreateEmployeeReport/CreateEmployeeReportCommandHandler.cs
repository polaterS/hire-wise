using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeReport.CreateEmployeeReport
{
    public class CreateEmployeeReportCommandHandler : IRequestHandler<CreateEmployeeReportCommandRequest, CreateEmployeeReportCommandResponse>
    {
        IEmployeeReportWriteRepository _employeeReportWriteRepository;

        public CreateEmployeeReportCommandHandler(IEmployeeReportWriteRepository employeeReportWriteRepository)
        {
            _employeeReportWriteRepository = employeeReportWriteRepository;
        }

        public async Task<CreateEmployeeReportCommandResponse> Handle(CreateEmployeeReportCommandRequest request, CancellationToken cancellationToken)
        {
            await _employeeReportWriteRepository.AddAsync(new()
            {
                Header = request.Header,
                Subject = request.Subject,
                Content = request.Content,
                Department = request.Department,
            });
            await _employeeReportWriteRepository.SaveAsync();

            return new();
        }
    }
}
