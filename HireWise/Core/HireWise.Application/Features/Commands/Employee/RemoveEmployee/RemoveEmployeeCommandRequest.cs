using MediatR;

namespace HireWise.Application.Features.Commands.Employee.RemoveEmployee
{
    public class RemoveEmployeeCommandRequest : IRequest<RemoveEmployeeCommandResponse>
    {
        public string Id { get; set; }
    }
}
