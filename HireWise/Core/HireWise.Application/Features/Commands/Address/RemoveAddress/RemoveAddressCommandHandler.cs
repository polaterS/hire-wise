using MediatR;

namespace HireWise.Application.Features.Commands.Address.RemoveAddress
{
    public class RemoveAddressCommandHandler : IRequestHandler<RemoveAddressCommandRequest, RemoveAddressCommandResponse>
    {
        readonly IAddressWriteRepository _addressWriteRepository;

        public RemoveAddressCommandHandler(IAddressWriteRepository addressWriteRepository)
        {
            _addressWriteRepository = addressWriteRepository;
        }

        public async Task<RemoveAddressCommandResponse> Handle(RemoveAddressCommandRequest request, CancellationToken cancellationToken)
        {
            await _addressWriteRepository.RemoveAsync(request.AddressId);
            await _addressWriteRepository.SaveAsync();
            return new();
        }
    }
}
