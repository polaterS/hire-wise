using MediatR;

namespace HireWise.Application.Features.Queries.JobPosting.GetAllJobPosting
{
    public class GetAllJobPostingQueryHandler : IRequestHandler<GetAllJobPostingQueryRequest, GetAllJobPostingQueryResponse>
    {
        IJobPostingReadRepository _jobPostingReadRepository;

        public GetAllJobPostingQueryHandler(IJobPostingReadRepository jobPostingReadRepository)
        {
            _jobPostingReadRepository = jobPostingReadRepository;
        }

        public async Task<GetAllJobPostingQueryResponse> Handle(GetAllJobPostingQueryRequest request, CancellationToken cancellationToken)
        {
            var totalJobPostingCount = _jobPostingReadRepository.GetAll(false).Count();
            var jobPostings = _jobPostingReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.CompanyName,
                d.Description,
                d.Location,
                d.ApplicationDeadline,
                d.Benefits,
                d.Qualifications,
                d.Experience,
                d.ModeOfOperation,
                d.Position
            }).ToList();

            return new()
            {
                JobPostings = jobPostings,
                TotalJobPostingCount = totalJobPostingCount
            };
        }
    }
}
