using MediatR;

namespace HireWise.Application.Features.Queries.JobPosting.GetByIdJobPosting
{
    public class GetByIdJobPostingQueryHandler : IRequestHandler<GetByIdJobPostingQueryRequest, GetByIdJobPostingQueryResponse>
    {
        IJobPostingReadRepository _jobPostingReadRepository;

        public GetByIdJobPostingQueryHandler(IJobPostingReadRepository jobPostingReadRepository)
        {
            _jobPostingReadRepository = jobPostingReadRepository;
        }

        public async Task<GetByIdJobPostingQueryResponse> Handle(GetByIdJobPostingQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.JobPosting jobPosting = await _jobPostingReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Position = jobPosting.Position,
                CompanyName = jobPosting.CompanyName,
                Experience = jobPosting.Experience,
                Location = jobPosting.Location,
                ModeOfOperation = jobPosting.ModeOfOperation,
                Description = jobPosting.Description,
                Qualifications = jobPosting.Qualifications,
                Benefits = jobPosting.Benefits,
                ApplicationDeadline = jobPosting.ApplicationDeadline,
            };
        }
    }
}
