using MediatR;

namespace HireWise.Application.Features.Queries.EventAndSeminar.GetByIdEventAndSeminar
{
    public class GetByIdEventAndSeminarQueryHandler : IRequestHandler<GetByIdEventAndSeminarQueryRequest, GetByIdEventAndSeminarQueryResponse>
    {
        IEventAndSeminarReadRepository _eventAndSeminarReadRepository;

        public GetByIdEventAndSeminarQueryHandler(IEventAndSeminarReadRepository eventAndSeminarReadRepository)
        {
            _eventAndSeminarReadRepository = eventAndSeminarReadRepository;
        }

        public async Task<GetByIdEventAndSeminarQueryResponse> Handle(GetByIdEventAndSeminarQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.EventAndSeminar eventAndSeminar = await _eventAndSeminarReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                EventName = eventAndSeminar.EventName,
                EventDate = eventAndSeminar.EventDate,
                EventLocation = eventAndSeminar.EventLocation,
                Description = eventAndSeminar.Description,
            };
        }
    }
}
