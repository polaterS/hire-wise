using MediatR;

namespace HireWise.Application.Features.Queries.Address.GetByIdAddress
{
    public class GetByIdAddressQueryRequest : IRequest<GetByIdAddressQueryResponse>
    {
        public string AddressId { get; set; }
    }
}
