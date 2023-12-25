using MediatR;

namespace HireWise.Application.Features.Commands.Position.RemovePosition
{
    public class RemovePositionCommandHandler : IRequestHandler<RemovePositionCommandRequest, RemovePositionCommandResponse>
    {
        IPositionWriteRepository _positionWriteRepository;

        public RemovePositionCommandHandler(IPositionWriteRepository positionWriteRepository)
        {
            _positionWriteRepository = positionWriteRepository;
        }

        public async Task<RemovePositionCommandResponse> Handle(RemovePositionCommandRequest request, CancellationToken cancellationToken)
        {
            await _positionWriteRepository.RemoveAsync(request.Id);
            await _positionWriteRepository.SaveAsync();
            return new();
        }
    }
}
