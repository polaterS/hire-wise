using MediatR;

namespace HireWise.Application.Features.Commands.Position.UpdatePosition
{
    public class UpdatePositionCommandHandler : IRequestHandler<UpdatePositionCommandRequest, UpdatePositionCommandResponse>
    {
        IPositionWriteRepository _positionWriteRepository;
        IPositionReadRepository _positionReadRepository;

        public UpdatePositionCommandHandler(IPositionWriteRepository positionWriteRepository, IPositionReadRepository positionReadRepository)
        {
            _positionWriteRepository = positionWriteRepository;
            _positionReadRepository = positionReadRepository;
        }

        public async Task<UpdatePositionCommandResponse> Handle(UpdatePositionCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Position position = await _positionReadRepository.GetByIdAsync(request.Id);
            position.Name = request.Name;
            await _positionWriteRepository.SaveAsync();
            return new();
        }
    }
}
