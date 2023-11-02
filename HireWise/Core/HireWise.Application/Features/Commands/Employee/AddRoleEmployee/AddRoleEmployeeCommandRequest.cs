using MediatR;

namespace HireWise.Application.Features.Commands.Employee.AddRoleEmployee
{
    public class AddRoleEmployeeCommandRequest:IRequest<AddRoleEmployeeCommandResponse>
    {
        public int EmployeeId { get; set; }
        public IList<string> RoleIds { get; set; }
    }
}
