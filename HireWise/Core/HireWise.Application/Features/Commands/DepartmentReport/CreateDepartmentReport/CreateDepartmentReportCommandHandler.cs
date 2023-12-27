using MediatR;

namespace HireWise.Application.Features.Commands.DepartmentReport.CreateDepartmentReport
{
    public class CreateDepartmentReportCommandHandler : IRequestHandler<CreateDepartmentReportCommandRequest, CreateDepartmentReportCommandResponse>
    {
        IDepartmentReportWriteRepository _departmentReportWriteRepository;

        public CreateDepartmentReportCommandHandler(IDepartmentReportWriteRepository departmentReportWriteRepository)
        {
            _departmentReportWriteRepository = departmentReportWriteRepository;
        }

        public async Task<CreateDepartmentReportCommandResponse> Handle(CreateDepartmentReportCommandRequest request, CancellationToken cancellationToken)
        {
            await _departmentReportWriteRepository.AddAsync(new()
            {
                Header = request.Header,
                Subject = request.Subject,
                Content = request.Content,
                Department = request.Department,
            });
            await _departmentReportWriteRepository.SaveAsync();

            return new();
        }
    }
}
