using MediatR;

namespace HireWise.Application.Features.Commands.SchoolExperience.RemoveSchoolExperience
{
    public class RemoveSchoolExperienceCommandHandler : IRequestHandler<RemoveSchoolExperienceCommandRequest, RemoveSchoolExperienceCommandResponse>
    {
        readonly ISchoolExperienceWriteRepository _schoolExperienceWriteRepository;

        public RemoveSchoolExperienceCommandHandler(ISchoolExperienceWriteRepository schoolExperienceWriteRepository)
        {
            _schoolExperienceWriteRepository = schoolExperienceWriteRepository;
        }

        public async Task<RemoveSchoolExperienceCommandResponse> Handle(RemoveSchoolExperienceCommandRequest request, CancellationToken cancellationToken)
        {
            await _schoolExperienceWriteRepository.RemoveAsync(request.SchoolExperienceId);
            await _schoolExperienceWriteRepository.SaveAsync();
            return new();
        }
    }
}
