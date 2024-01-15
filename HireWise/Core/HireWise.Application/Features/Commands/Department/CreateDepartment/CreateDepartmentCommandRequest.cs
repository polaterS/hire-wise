using MediatR;

namespace HireWise.Application.Features.Commands.Department.CreateDepartment
{
    public class CreateDepartmentCommandRequest : IRequest<CreateDepartmentCommandResponse>
    {
        public string Name { get; set; }
    }
}
