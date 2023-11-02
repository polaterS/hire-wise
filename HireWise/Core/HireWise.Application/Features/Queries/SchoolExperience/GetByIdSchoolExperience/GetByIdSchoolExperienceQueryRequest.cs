using MediatR;

namespace HireWise.Application.Features.Queries.SchoolExperience.GetByIdSchoolExperience
{
    public class GetByIdSchoolExperienceQueryRequest : IRequest<GetByIdSchoolExperienceQueryResponse>
    {
        public string Id { get; set; }
    }
}
