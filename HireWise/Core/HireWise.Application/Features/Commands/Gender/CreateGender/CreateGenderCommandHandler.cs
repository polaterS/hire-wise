using MediatR;

namespace HireWise.Application.Features.Commands.Gender.CreateGender
{
    public class CreateGenderCommandHandler : IRequestHandler<CreateGenderCommandRequest, CreateGenderCommandResponse>
    {
        readonly IGenderWriteRepository _genderWriteRepository;

        public CreateGenderCommandHandler(IGenderWriteRepository genderWriteRepository)
        {
            _genderWriteRepository = genderWriteRepository;
        }

        public async Task<CreateGenderCommandResponse> Handle(CreateGenderCommandRequest request, CancellationToken cancellationToken)
        {
            await _genderWriteRepository.AddAsync(new()
            {
                Name = request.Name
            });
            await _genderWriteRepository.SaveAsync();

            return new();
        }
    }
}
