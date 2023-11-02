using HireWise.Application.Abstractions.Services;
using HireWise.Domain.Entities.Identity;
using MediatR;

namespace HireWise.Application.Features.Commands.Employee.AddRoleEmployee
{
    public class AddRoleEmployeeCommandHandler : IRequestHandler<AddRoleEmployeeCommandRequest, AddRoleEmployeeCommandResponse>
    {
        #region fields
            private readonly IEmployeeReadRepository _employeeReadRepository;
            private readonly IEmployeeWriteRepository _employeeWriteRepository;
            private readonly IRoleService _roleService;
        #endregion

        #region ctor
        public AddRoleEmployeeCommandHandler(IEmployeeReadRepository employeeReadRepository, IEmployeeWriteRepository employeeWriteRepository, IRoleService roleService)
        {
            _employeeReadRepository = employeeReadRepository;
            _employeeWriteRepository = employeeWriteRepository;
            _roleService = roleService;
        }
        #endregion

        public  Task<AddRoleEmployeeCommandResponse> Handle(AddRoleEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            
        }
    }
}
