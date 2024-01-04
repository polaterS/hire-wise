using MediatR;

namespace HireWise.Application.Features.Queries.EventAndSeminar.GetAllEventAndSeminar
{
    public class GetAllEventAndSeminarQueryHandler : IRequestHandler<GetAllEventAndSeminarQueryRequest, GetAllEventAndSeminarQueryResponse>
    {
        IEventAndSeminarReadRepository _eventAndSeminarReadRepository;

        public GetAllEventAndSeminarQueryHandler(IEventAndSeminarReadRepository eventAndSeminarReadRepository)
        {
            _eventAndSeminarReadRepository = eventAndSeminarReadRepository;
        }

        public async Task<GetAllEventAndSeminarQueryResponse> Handle(GetAllEventAndSeminarQueryRequest request, CancellationToken cancellationToken)
        {
            var totalEventAndSeminarCount = _eventAndSeminarReadRepository.GetAll(false).Count();
            var eventAndSeminars = _eventAndSeminarReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.EventName,
                d.EventLocation,
                d.EventDate,
                d.Description,
            }).ToList();

            return new()
            {
                EventAndSeminars = eventAndSeminars,
                TotalEventAndSeminarCount = totalEventAndSeminarCount
            };
        }
    }
}
