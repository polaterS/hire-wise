using MediatR;

namespace HireWise.Application.Features.Queries.MaritalStatu.GetAllMaritalStatu
{
    public class GetAllMaritalStatuQueryRequest : IRequest<GetAllMaritalStatuQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
