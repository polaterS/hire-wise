using MediatR;

namespace HireWise.Application.Features.Commands.DepartmentReport.UpdateDepartmentReport
{
    public class UpdateDepartmentReportCommandHandler : IRequestHandler<UpdateDepartmentReportCommandRequest, UpdateDepartmentReportCommandResponse>
    {
        IDepartmentReportWriteRepository _departmentReportWriteRepository;
        IDepartmentReportReadRepository _departmentReportReadRepository;

        public UpdateDepartmentReportCommandHandler(IDepartmentReportWriteRepository departmentReportWriteRepository, IDepartmentReportReadRepository departmentReportReadRepository)
        {
            _departmentReportWriteRepository = departmentReportWriteRepository;
            _departmentReportReadRepository = departmentReportReadRepository;
        }

        public async Task<UpdateDepartmentReportCommandResponse> Handle(UpdateDepartmentReportCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.DepartmentReport departmentReport = await _departmentReportReadRepository.GetByIdAsync(request.Id);
            departmentReport.Header = request.Header;
            departmentReport.Subject = request.Subject;
            departmentReport.Content = request.Content;
            departmentReport.Department = request.Department;
            await _departmentReportWriteRepository.SaveAsync();
            return new();
        }
    }
}
