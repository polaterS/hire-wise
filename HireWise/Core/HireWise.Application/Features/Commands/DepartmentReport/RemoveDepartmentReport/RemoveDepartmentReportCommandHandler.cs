using MediatR;

namespace HireWise.Application.Features.Commands.DepartmentReport.RemoveDepartmentReport
{
    public class RemoveDepartmentReportCommandHandler : IRequestHandler<RemoveDepartmentReportCommandRequest, RemoveDepartmentReportCommandResponse>
    {
        IDepartmentReportWriteRepository _departmentReportWriteRepository;

        public RemoveDepartmentReportCommandHandler(IDepartmentReportWriteRepository departmentReportWriteRepository)
        {
            _departmentReportWriteRepository = departmentReportWriteRepository;
        }

        public async Task<RemoveDepartmentReportCommandResponse> Handle(RemoveDepartmentReportCommandRequest request, CancellationToken cancellationToken)
        {
            await _departmentReportWriteRepository.RemoveAsync(request.Id);
            await _departmentReportWriteRepository.SaveAsync();
            return new();
        }
    }
}
