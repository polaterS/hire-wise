using MediatR;

namespace HireWise.Application.Features.Commands.Department.RemoveDepartment
{
    public class RemoveDepartmentCommandHandler : IRequestHandler<RemoveDepartmentCommandRequest, RemoveDepartmentCommandResponse>
    {
        readonly IDepartmentWriteRepository _departmentWriteRepository;

        public RemoveDepartmentCommandHandler(IDepartmentWriteRepository departmentWriteRepository)
        {
            _departmentWriteRepository = departmentWriteRepository;
        }

        public async Task<RemoveDepartmentCommandResponse> Handle(RemoveDepartmentCommandRequest request, CancellationToken cancellationToken)
        {
            await _departmentWriteRepository.RemoveAsync(request.Id);
            await _departmentWriteRepository.SaveAsync();
            return new();
        }
    }
}
