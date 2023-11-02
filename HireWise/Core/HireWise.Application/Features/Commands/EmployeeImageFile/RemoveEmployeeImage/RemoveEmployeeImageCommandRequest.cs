using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeImageFile.RemoveEmployeeImage
{
    public class RemoveEmployeeImageCommandRequest : IRequest<RemoveEmployeeImageCommandResponse>
    {
        public string Id { get; set; }
        public string? ImageId { get; set; }
    }
}
