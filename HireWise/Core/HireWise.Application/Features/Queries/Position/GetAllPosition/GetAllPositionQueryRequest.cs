using MediatR;

namespace HireWise.Application.Features.Queries.Position.GetAllPosition
{
    public class GetAllPositionQueryRequest : IRequest<GetAllPositionQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
