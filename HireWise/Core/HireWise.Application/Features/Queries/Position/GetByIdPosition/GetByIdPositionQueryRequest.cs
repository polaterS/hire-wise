using MediatR;

namespace HireWise.Application.Features.Queries.Position.GetByIdPosition
{
    public class GetByIdPositionQueryRequest : IRequest<GetByIdPositionQueryResponse>
    {
        public string Id { get; set; }
    }
}
