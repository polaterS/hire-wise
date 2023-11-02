using MediatR;

namespace HireWise.Application.Features.Queries.MaritalStatu.GetByIdMaritalStatu
{
    public class GetByIdMaritalStatuQueryRequest : IRequest<GetByIdMaritalStatuQueryResponse>
    {
        public string Id { get; set; }
    }
}
