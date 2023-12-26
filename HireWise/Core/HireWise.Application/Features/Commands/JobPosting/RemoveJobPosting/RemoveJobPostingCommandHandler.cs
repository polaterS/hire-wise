using MediatR;

namespace HireWise.Application.Features.Commands.JobPosting.RemoveJobPosting
{
    public class RemoveJobPostingCommandHandler : IRequestHandler<RemoveJobPostingCommandRequest, RemoveJobPostingCommandResponse>
    {
        IJobPostingWriteRepository _jobPostingWriteRepository;

        public RemoveJobPostingCommandHandler(IJobPostingWriteRepository jobPostingWriteRepository)
        {
            _jobPostingWriteRepository = jobPostingWriteRepository;
        }

        public async Task<RemoveJobPostingCommandResponse> Handle(RemoveJobPostingCommandRequest request, CancellationToken cancellationToken)
        {
            await _jobPostingWriteRepository.RemoveAsync(request.JobPostingId);
            await _jobPostingWriteRepository.SaveAsync();
            return new();
        }
    }
}
