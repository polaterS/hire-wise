using MediatR;

namespace HireWise.Application.Features.Commands.Department.CreateDepartment
{
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommandRequest, CreateDepartmentCommandResponse>
    {
        readonly IDepartmentWriteRepository _departmentWriteRepository;

        public CreateDepartmentCommandHandler(IDepartmentWriteRepository departmentWriteRepository)
        {
            _departmentWriteRepository = departmentWriteRepository;
        }

        public async Task<CreateDepartmentCommandResponse> Handle(CreateDepartmentCommandRequest request, CancellationToken cancellationToken)
        {
            await _departmentWriteRepository.AddAsync(new()
            {
                Name = request.Name,
            });
            await _departmentWriteRepository.SaveAsync();

            return new();
        }
    }
}
