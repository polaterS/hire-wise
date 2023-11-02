using MediatR;

namespace HireWise.Application.Features.Commands.Department.RemoveDepartment
{
    public class RemoveDepartmentCommandRequest : IRequest<RemoveDepartmentCommandResponse>
    {
        public string Id { get; set; }
    }
}
