using MediatR;

namespace HireWise.Application.Features.Commands.Department.UpdateDepartment
{
    public class UpdateDepartmentCommandRequest : IRequest<UpdateDepartmentCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
