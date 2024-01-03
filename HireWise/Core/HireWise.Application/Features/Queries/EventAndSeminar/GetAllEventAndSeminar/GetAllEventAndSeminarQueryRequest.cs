using MediatR;

namespace HireWise.Application.Features.Queries.EventAndSeminar.GetAllEventAndSeminar
{
    public class GetAllEventAndSeminarQueryRequest : IRequest<GetAllEventAndSeminarQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
