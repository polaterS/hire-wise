using MediatR;

namespace HireWise.Application.Features.Commands.JobPosting.RemoveJobPosting
{
    public class RemoveJobPostingCommandRequest : IRequest<RemoveJobPostingCommandResponse>
    {
        public string JobPostingId { get; set; }
    }
}
