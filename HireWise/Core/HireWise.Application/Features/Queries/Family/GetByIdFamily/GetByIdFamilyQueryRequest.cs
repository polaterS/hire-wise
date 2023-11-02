using MediatR;

namespace HireWise.Application.Features.Queries.Family.GetByIdFamily
{
    public class GetByIdFamilyQueryRequest : IRequest<GetByIdFamilyQueryResponse>
    {
        public string Id { get; set; }
    }
}
