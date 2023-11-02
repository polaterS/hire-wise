using MediatR;

namespace HireWise.Application.Features.Queries.WorkExperience.GetByIdWorkExperience
{
    public class GetByIdWorkExperienceQueryRequest : IRequest<GetByIdWorkExperienceQueryResponse>
    {
        public string Id { get; set; }
    }
}
