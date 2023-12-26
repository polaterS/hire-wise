using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.UpdateEventAndSeminar
{
    public class UpdateEventAndSeminarCommandHandler : IRequestHandler<UpdateEventAndSeminarCommandRequest, UpdateEventAndSeminarCommandResponse>
    {
        IEventAndSeminarWriteRepository _eventAndSeminarWriteRepository;
        IEventAndSeminarReadRepository _eventAndSeminarReadRepository;

        public UpdateEventAndSeminarCommandHandler(IEventAndSeminarWriteRepository eventAndSeminarWriteRepository, IEventAndSeminarReadRepository eventAndSeminarReadRepository)
        {
            _eventAndSeminarWriteRepository = eventAndSeminarWriteRepository;
            _eventAndSeminarReadRepository = eventAndSeminarReadRepository;
        }

        public async Task<UpdateEventAndSeminarCommandResponse> Handle(UpdateEventAndSeminarCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.EventAndSeminar eventAndSeminar = await _eventAndSeminarReadRepository.GetByIdAsync(request.EventAndSeminarId);
            eventAndSeminar.Name = request.Name;
            eventAndSeminar.EventDate = request.EventDate;
            eventAndSeminar.Location = request.Location;
            eventAndSeminar.Description = request.Description;
            await _eventAndSeminarWriteRepository.SaveAsync();
            return new();
        }
    }
}
