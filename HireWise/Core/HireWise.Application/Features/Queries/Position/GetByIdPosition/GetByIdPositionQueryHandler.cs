using MediatR;

namespace HireWise.Application.Features.Queries.Position.GetByIdPosition
{
    public class GetByIdPositionQueryHandler : IRequestHandler<GetByIdPositionQueryRequest, GetByIdPositionQueryResponse>
    {
        IPositionReadRepository _positionReadRepository;

        public GetByIdPositionQueryHandler(IPositionReadRepository positionReadRepository)
        {
            _positionReadRepository = positionReadRepository;
        }

        public async Task<GetByIdPositionQueryResponse> Handle(GetByIdPositionQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Position position = await _positionReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = position.Name
            };
        }
    }
}
