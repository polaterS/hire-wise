using MediatR;

namespace HireWise.Application.Features.Queries.JobPosting.GetAllJobPosting
{
    public class GetAllJobPostingQueryRequest : IRequest<GetAllJobPostingQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
