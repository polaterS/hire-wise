using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.CreateEventAndSeminar
{
    public class CreateEventAndSeminarCommandHandler : IRequestHandler<CreateEventAndSeminarCommandRequest, CreateEventAndSeminarCommandResponse>
    {
        IEventAndSeminarWriteRepository _eventAndSeminarWriteRepository;

        public CreateEventAndSeminarCommandHandler(IEventAndSeminarWriteRepository eventAndSeminarWriteRepository)
        {
            _eventAndSeminarWriteRepository = eventAndSeminarWriteRepository;
        }

        public async Task<CreateEventAndSeminarCommandResponse> Handle(CreateEventAndSeminarCommandRequest request, CancellationToken cancellationToken)
        {
            await _eventAndSeminarWriteRepository.AddAsync(new()
            {
                EventName = request.EventName,
                EventDate = request.EventDate,
                EventLocation = request.EventLocation,
                Description = request.Description
            });
            await _eventAndSeminarWriteRepository.SaveAsync();

            return new();
        }
    }
}
