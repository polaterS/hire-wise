using MediatR;

namespace HireWise.Application.Features.Commands.WorkExperience.RemoveWorkExperience
{
    public class RemoveWorkExperienceCommandRequest : IRequest<RemoveWorkExperienceCommandResponse>
    {
        public string WorkExperienceId { get; set; }
    }
}
