using MediatR;

namespace HireWise.Application.Features.Commands.Address.CreateAddress
{
    public class CreateAddressCommandHandler : IRequestHandler<CreateAddressCommandRequest, CreateAddressCommandResponse>
    {
        readonly IAddressWriteRepository _addressWriteRepository;

        public CreateAddressCommandHandler(IAddressWriteRepository addressWriteRepository)
        {
            _addressWriteRepository = addressWriteRepository;
        }

        public async Task<CreateAddressCommandResponse> Handle(CreateAddressCommandRequest request, CancellationToken cancellationToken)
        {
            await _addressWriteRepository.AddAsync(new()
            {
                EmployeeId = request.EmployeeId,
                Title = request.Title,
                Street = request.Street,
                City = request.City,
                Country = request.Country,
                PostalCode = request.PostalCode
            });
            await _addressWriteRepository.SaveAsync();

            return new();
        }
    }
}
