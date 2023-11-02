using MediatR;

namespace HireWise.Application.Features.Commands.Address.RemoveAddress
{
    public class RemoveAddressCommandRequest : IRequest<RemoveAddressCommandResponse>
    {
        public string AddressId { get; set; }
    }
}
