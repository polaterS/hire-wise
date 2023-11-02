using MediatR;

namespace HireWise.Application.Features.Commands.Family.RemoveFamily
{
    public class RemoveFamilyCommandHandler : IRequestHandler<RemoveFamilyCommandRequest, RemoveFamilyCommandResponse>
    {
        readonly IFamilyWriteRepository _familyWriteRepository;

        public RemoveFamilyCommandHandler(IFamilyWriteRepository familyWriteRepository)
        {
            _familyWriteRepository = familyWriteRepository;
        }

        public async Task<RemoveFamilyCommandResponse> Handle(RemoveFamilyCommandRequest request, CancellationToken cancellationToken)
        {
            await _familyWriteRepository.RemoveAsync(request.Id);
            await _familyWriteRepository.SaveAsync();
            return new();
        }
    }
}
