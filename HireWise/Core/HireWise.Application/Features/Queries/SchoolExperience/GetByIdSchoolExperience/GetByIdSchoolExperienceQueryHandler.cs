using MediatR;

namespace HireWise.Application.Features.Queries.SchoolExperience.GetByIdSchoolExperience
{
    public class GetByIdSchoolExperienceQueryHandler : IRequestHandler<GetByIdSchoolExperienceQueryRequest, GetByIdSchoolExperienceQueryResponse>
    {
        readonly ISchoolExperienceReadRepository _schoolExperienceReadRepository;

        public GetByIdSchoolExperienceQueryHandler(ISchoolExperienceReadRepository schoolExperienceReadRepository)
        {
            _schoolExperienceReadRepository = schoolExperienceReadRepository;
        }

        public async Task<GetByIdSchoolExperienceQueryResponse> Handle(GetByIdSchoolExperienceQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.SchoolExperience schoolExperience = await _schoolExperienceReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                EmployeeId = schoolExperience.EmployeeId,
                SchoolName = schoolExperience.SchoolName,
                SchoolType = schoolExperience.SchoolType,
                Grade = schoolExperience.Grade,
                SchoolDateOfStartOnUtc = schoolExperience.SchoolDateOfStartOnUtc,
                SchoolDateOfEndOnUtc = schoolExperience.SchoolDateOfEndOnUtc
            };
        }
    }
}
