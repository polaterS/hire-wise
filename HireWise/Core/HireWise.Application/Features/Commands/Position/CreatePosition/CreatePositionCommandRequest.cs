using MediatR;

namespace HireWise.Application.Features.Commands.Position.CreatePosition
{
    public class CreatePositionCommandRequest : IRequest<CreatePositionCommandResponse>
    {
        public string Name { get; set; }
    }
}
