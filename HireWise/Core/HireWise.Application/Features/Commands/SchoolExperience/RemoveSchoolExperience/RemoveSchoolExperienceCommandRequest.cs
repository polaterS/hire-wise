using MediatR;

namespace HireWise.Application.Features.Commands.SchoolExperience.RemoveSchoolExperience
{
    public class RemoveSchoolExperienceCommandRequest : IRequest<RemoveSchoolExperienceCommandResponse>
    {
        public string SchoolExperienceId { get; set; }
    }
}
