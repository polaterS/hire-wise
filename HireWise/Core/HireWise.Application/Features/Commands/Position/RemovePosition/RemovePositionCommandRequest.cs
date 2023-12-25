using MediatR;

namespace HireWise.Application.Features.Commands.Position.RemovePosition
{
    public class RemovePositionCommandRequest : IRequest<RemovePositionCommandResponse>
    {
        public string Id { get; set; }
    }
}
