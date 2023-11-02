using MediatR;

namespace HireWise.Application.Features.Commands.Gender.RemoveGender
{
    public class RemoveGenderCommandHandler : IRequestHandler<RemoveGenderCommandRequest, RemoveGenderCommandResponse>
    {
        readonly IGenderWriteRepository _genderWriteRepository;

        public RemoveGenderCommandHandler(IGenderWriteRepository genderWriteRepository)
        {
            _genderWriteRepository = genderWriteRepository;
        }

        public async Task<RemoveGenderCommandResponse> Handle(RemoveGenderCommandRequest request, CancellationToken cancellationToken)
        {
            await _genderWriteRepository.RemoveAsync(request.Id);
            await _genderWriteRepository.SaveAsync();
            return new();
        }
    }
}
