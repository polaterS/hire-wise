using MediatR;

namespace HireWise.Application.Features.Commands.SchoolExperience.CreateSchoolExperience
{
    public class CreateSchoolExperienceCommandHandler : IRequestHandler<CreateSchoolExperienceCommandRequest, CreateSchoolExperienceCommandResponse>
    {
        readonly ISchoolExperienceWriteRepository _schoolExperienceWriteRepository;

        public CreateSchoolExperienceCommandHandler(ISchoolExperienceWriteRepository schoolExperienceWriteRepository)
        {
            _schoolExperienceWriteRepository = schoolExperienceWriteRepository;
        }

        public async Task<CreateSchoolExperienceCommandResponse> Handle(CreateSchoolExperienceCommandRequest request, CancellationToken cancellationToken)
        {
            await _schoolExperienceWriteRepository.AddAsync(new()
            {
                EmployeeId = request.EmployeeId,
                SchoolName = request.SchoolName,
                SchoolType = request.SchoolType,
                Grade = request.Grade,
                SchoolDateOfStartOnUtc = request.SchoolDateOfStartOnUtc,
                SchoolDateOfEndOnUtc = request.SchoolDateOfEndOnUtc
            });
            await _schoolExperienceWriteRepository.SaveAsync();

            return new();
        }
    }
}
