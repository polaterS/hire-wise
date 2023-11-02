using MediatR;

namespace HireWise.Application.Features.Queries.Address.GetByIdAddress
{
    public class GetByIdAddressQueryHandler : IRequestHandler<GetByIdAddressQueryRequest, GetByIdAddressQueryResponse>
    {
        readonly IAddressReadRepository _addressReadRepository;

        public GetByIdAddressQueryHandler(IAddressReadRepository addressReadRepository)
        {
            _addressReadRepository = addressReadRepository;
        }

        public async Task<GetByIdAddressQueryResponse> Handle(GetByIdAddressQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Address address = await _addressReadRepository.GetByIdAsync(request.AddressId, false);
            return new()
            {
                EmployeeId = address.EmployeeId,
                Title = address.Title,
                Street = address.Street,
                City = address.City,
                Country = address.Country,
                PostalCode = address.PostalCode
            };
        }
    }
}
