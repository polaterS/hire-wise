using MediatR;

namespace HireWise.Application.Features.Commands.Gender.UpdateGender
{
    public class UpdateGenderCommandHandler : IRequestHandler<UpdateGenderCommandRequest, UpdateGenderCommandResponse>
    {
        readonly IGenderWriteRepository _genderWriteRepository;
        readonly IGenderReadRepository _genderReadRepository;

        public UpdateGenderCommandHandler(IGenderWriteRepository genderWriteRepository, IGenderReadRepository genderReadRepository)
        {
            _genderWriteRepository = genderWriteRepository;
            _genderReadRepository = genderReadRepository;
        }

        public async Task<UpdateGenderCommandResponse> Handle(UpdateGenderCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Gender gender = await _genderReadRepository.GetByIdAsync(request.Id);
            gender.Name = request.Name;
            await _genderWriteRepository.SaveAsync();
            return new();
        }
    }
}
