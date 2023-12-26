using MediatR;

namespace HireWise.Application.Features.Commands.Department.UpdateDepartment
{
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommandRequest, UpdateDepartmentCommandResponse>
    {
        readonly IDepartmentWriteRepository _departmentWriteRepository;
        readonly IDepartmentReadRepository _departmentReadRepository;

        public UpdateDepartmentCommandHandler(IDepartmentWriteRepository departmentWriteRepository, IDepartmentReadRepository departmentReadRepository)
        {
            _departmentWriteRepository = departmentWriteRepository;
            _departmentReadRepository = departmentReadRepository;
        }

        public async Task<UpdateDepartmentCommandResponse> Handle(UpdateDepartmentCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Department department = await _departmentReadRepository.GetByIdAsync(request.Id);
            department.Name = request.Name;
            await _departmentWriteRepository.SaveAsync();
            return new();
        }
    }
}
