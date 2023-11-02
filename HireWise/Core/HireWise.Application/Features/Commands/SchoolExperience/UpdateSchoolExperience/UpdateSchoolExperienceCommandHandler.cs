using MediatR;

namespace HireWise.Application.Features.Commands.SchoolExperience.UpdateSchoolExperience
{
    public class UpdateSchoolExperienceCommandHandler : IRequestHandler<UpdateSchoolExperienceCommandRequest, UpdateSchoolExperienceCommandResponse>
    {
        readonly ISchoolExperienceWriteRepository _schoolExperienceWriteRepository;
        readonly ISchoolExperienceReadRepository _schoolExperienceReadRepository;

        public UpdateSchoolExperienceCommandHandler(ISchoolExperienceWriteRepository schoolExperienceWriteRepository, ISchoolExperienceReadRepository schoolExperienceReadRepository)
        {
            _schoolExperienceWriteRepository = schoolExperienceWriteRepository;
            _schoolExperienceReadRepository = schoolExperienceReadRepository;
        }

        public async Task<UpdateSchoolExperienceCommandResponse> Handle(UpdateSchoolExperienceCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.SchoolExperience schoolExperience = await _schoolExperienceReadRepository.GetByIdAsync(request.SchoolExperienceId);
            schoolExperience.SchoolName = request.SchoolName;
            schoolExperience.SchoolType = request.SchoolType;
            schoolExperience.Grade = request.Grade;
            schoolExperience.SchoolDateOfStartOnUtc = request.SchoolDateOfStartOnUtc;
            schoolExperience.SchoolDateOfEndOnUtc = request.SchoolDateOfEndOnUtc;
            await _schoolExperienceWriteRepository.SaveAsync();
            return new();
        }
    }
}
