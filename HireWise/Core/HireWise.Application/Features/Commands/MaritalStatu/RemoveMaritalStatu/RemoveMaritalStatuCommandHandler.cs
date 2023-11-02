using MediatR;

namespace HireWise.Application.Features.Commands.MaritalStatu.RemoveMaritalStatu
{
    public class RemoveMaritalStatuCommandHandler : IRequestHandler<RemoveMaritalStatuCommandRequest, RemoveMaritalStatuCommandResponse>
    {
        readonly IMaritalStatuWriteRepository _maritalStatuWriteRepository;

        public RemoveMaritalStatuCommandHandler(IMaritalStatuWriteRepository maritalStatuWriteRepository)
        {
            _maritalStatuWriteRepository = maritalStatuWriteRepository;
        }

        public async Task<RemoveMaritalStatuCommandResponse> Handle(RemoveMaritalStatuCommandRequest request, CancellationToken cancellationToken)
        {
            await _maritalStatuWriteRepository.RemoveAsync(request.Id);
            await _maritalStatuWriteRepository.SaveAsync();
            return new();
        }
    }
}
