using MediatR;

namespace HireWise.Application.Features.Queries.WorkExperience.GetByIdWorkExperience
{
    public class GetByIdWorkExperienceQueryHandler : IRequestHandler<GetByIdWorkExperienceQueryRequest, GetByIdWorkExperienceQueryResponse>
    {
        readonly IWorkExperienceReadRepository _workExperienceReadRepository;

        public GetByIdWorkExperienceQueryHandler(IWorkExperienceReadRepository workExperienceReadRepository)
        {
            _workExperienceReadRepository = workExperienceReadRepository;
        }

        public async Task<GetByIdWorkExperienceQueryResponse> Handle(GetByIdWorkExperienceQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.WorkExperience workExperience = await _workExperienceReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                EmployeeId = workExperience.EmployeeId,
                Departmant = workExperience.Departmant,
                Position = workExperience.Position,
                CompanyName = workExperience.CompanyName,
                WorkDateOfStart = workExperience.WorkDateOfStart,
                WorkDateOfEnd = workExperience.WorkDateOfEnd,
            };
        }
    }
}
