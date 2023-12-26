using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.RemoveEventAndSeminar
{
    public class RemoveEventAndSeminarCommandHandler : IRequestHandler<RemoveEventAndSeminarCommandRequest, RemoveEventAndSeminarCommandResponse>
    {
        IEventAndSeminarWriteRepository _eventAndSeminarWriteRepository;

        public RemoveEventAndSeminarCommandHandler(IEventAndSeminarWriteRepository eventAndSeminarWriteRepository)
        {
            _eventAndSeminarWriteRepository = eventAndSeminarWriteRepository;
        }

        public async Task<RemoveEventAndSeminarCommandResponse> Handle(RemoveEventAndSeminarCommandRequest request, CancellationToken cancellationToken)
        {
            await _eventAndSeminarWriteRepository.RemoveAsync(request.EventAndSeminarId);
            await _eventAndSeminarWriteRepository.SaveAsync();
            return new();
        }
    }
}
