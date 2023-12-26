using MediatR;

namespace HireWise.Application.Features.Queries.EventAndSeminar.GetByIdEventAndSeminar
{
    public class GetByIdEventAndSeminarQueryRequest : IRequest<GetByIdEventAndSeminarQueryResponse>
    {
        public string Id { get; set; }
    }
}
