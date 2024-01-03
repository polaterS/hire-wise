using MediatR;

namespace HireWise.Application.Features.Commands.JobPosting.CreateJobPosting
{
    public class CreateJobPostingCommandHandler : IRequestHandler<CreateJobPostingCommandRequest, CreateJobPostingCommandResponse>
    {
        IJobPostingWriteRepository _jobPostingWriteRepository;

        public CreateJobPostingCommandHandler(IJobPostingWriteRepository jobPostingWriteRepository)
        {
            _jobPostingWriteRepository = jobPostingWriteRepository;
        }

        public async Task<CreateJobPostingCommandResponse> Handle(CreateJobPostingCommandRequest request, CancellationToken cancellationToken)
        {
            await _jobPostingWriteRepository.AddAsync(new()
            {
                Position = request.Position,
                CompanyName = request.CompanyName,
                Experience = request.Experience,
                Location = request.Location,
                ModeOfOperation = request.ModeOfOperation,
                Description = request.Description,
                Qualifications = request.Qualifications,
                Benefits = request.Benefits,
                ApplicationDeadline = request.ApplicationDeadline,
            });
            await _jobPostingWriteRepository.SaveAsync();

            return new();
        }
    }
}
