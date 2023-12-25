using MediatR;

namespace HireWise.Application.Features.Commands.Position.CreatePosition
{
    public class CreatePositionCommandHandler : IRequestHandler<CreatePositionCommandRequest, CreatePositionCommandResponse>
    {
        IPositionWriteRepository _positionWriteRepository;

        public CreatePositionCommandHandler(IPositionWriteRepository positionWriteRepository)
        {
            _positionWriteRepository = positionWriteRepository;
        }

        public async Task<CreatePositionCommandResponse> Handle(CreatePositionCommandRequest request, CancellationToken cancellationToken)
        {
            await _positionWriteRepository.AddAsync(new()
            {
                Name = request.Name,
            });
            await _positionWriteRepository.SaveAsync();

            return new();
        }
    }
}
