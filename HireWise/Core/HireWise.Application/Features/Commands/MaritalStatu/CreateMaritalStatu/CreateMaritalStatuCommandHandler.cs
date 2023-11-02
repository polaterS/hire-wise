using MediatR;

namespace HireWise.Application.Features.Commands.MaritalStatu.CreateMaritalStatu
{
    public class CreateMaritalStatuCommandHandler : IRequestHandler<CreateMaritalStatuCommandRequest, CreateMaritalStatuCommandResponse>
    {
        IMaritalStatuWriteRepository _maritalStatuWriteRepository;

        public CreateMaritalStatuCommandHandler(IMaritalStatuWriteRepository maritalStatuWriteRepository)
        {
            _maritalStatuWriteRepository = maritalStatuWriteRepository;
        }

        public async Task<CreateMaritalStatuCommandResponse> Handle(CreateMaritalStatuCommandRequest request, CancellationToken cancellationToken)
        {
            await _maritalStatuWriteRepository.AddAsync(new()
            {
                Name = request.Name,
            });
            await _maritalStatuWriteRepository.SaveAsync();

            return new();
        }
    }
}
