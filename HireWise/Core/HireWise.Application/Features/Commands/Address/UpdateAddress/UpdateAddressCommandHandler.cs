using MediatR;

namespace HireWise.Application.Features.Commands.Address.UpdateAddress
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddressCommandRequest, UpdateAddressCommandResponse>
    {
        readonly IAddressReadRepository _addressReadRepository;
        readonly IAddressWriteRepository _addressWriteRepository;

        public UpdateAddressCommandHandler(IAddressReadRepository addressReadRepository, IAddressWriteRepository addressWriteRepository)
        {
            _addressReadRepository = addressReadRepository;
            _addressWriteRepository = addressWriteRepository;
        }

        public async Task<UpdateAddressCommandResponse> Handle(UpdateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Address address = await _addressReadRepository.GetByIdAsync(request.AddressId);
            address.Title = request.Title;
            address.Street = request.Street;
            address.City = request.City;
            address.Country = request.Country;
            address.PostalCode = request.PostalCode;
            await _addressWriteRepository.SaveAsync();
            return new();
        }
    }
}
