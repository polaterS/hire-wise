using MediatR;

namespace HireWise.Application.Features.Commands.Position.UpdatePosition
{
    public class UpdatePositionCommandRequest : IRequest<UpdatePositionCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
