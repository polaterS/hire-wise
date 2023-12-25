using MediatR;

namespace HireWise.Application.Features.Queries.Position.GetAllPosition
{
    public class GetAllPositionQueryHandler : IRequestHandler<GetAllPositionQueryRequest, GetAllPositionQueryResponse>
    {
        IPositionReadRepository _positionReadRepository;

        public GetAllPositionQueryHandler(IPositionReadRepository positionReadRepository)
        {
            _positionReadRepository = positionReadRepository;
        }

        public async Task<GetAllPositionQueryResponse> Handle(GetAllPositionQueryRequest request, CancellationToken cancellationToken)
        {
            var totalPositionCount = _positionReadRepository.GetAll(false).Count();
            var positions = _positionReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.Name
            }).ToList();

            return new()
            {
                Positions = positions,
                TotalPositionCount = totalPositionCount
            };
        }
    }
}
