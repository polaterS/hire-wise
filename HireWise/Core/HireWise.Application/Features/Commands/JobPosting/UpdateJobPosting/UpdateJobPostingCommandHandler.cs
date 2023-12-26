using MediatR;

namespace HireWise.Application.Features.Commands.JobPosting.UpdateJobPosting
{
    public class UpdateJobPostingCommandHandler : IRequestHandler<UpdateJobPostingCommandRequest, UpdateJobPostingCommandResponse>
    {
        IJobPostingWriteRepository _jobPostingWriteRepository;
        IJobPostingReadRepository _jobPostingReadRepository;

        public UpdateJobPostingCommandHandler(IJobPostingWriteRepository jobPostingWriteRepository, IJobPostingReadRepository jobPostingReadRepository)
        {
            _jobPostingWriteRepository = jobPostingWriteRepository;
            _jobPostingReadRepository = jobPostingReadRepository;
        }

        public async Task<UpdateJobPostingCommandResponse> Handle(UpdateJobPostingCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.JobPosting jobPosting = await _jobPostingReadRepository.GetByIdAsync(request.JobPostingId);
            jobPosting.Position = request.Position;
            jobPosting.CompanyName = request.CompanyName;
            jobPosting.Experience = request.Experience;
            jobPosting.Location = request.Location;
            jobPosting.Operation = request.Operation;
            jobPosting.Description = request.Description;
            jobPosting.Qualifications = request.Qualifications;
            jobPosting.Benefits = request.Benefits;
            jobPosting.ApplicationDeadline = request.ApplicationDeadline;
            await _jobPostingWriteRepository.SaveAsync();
            return new();
        }
    }
}
