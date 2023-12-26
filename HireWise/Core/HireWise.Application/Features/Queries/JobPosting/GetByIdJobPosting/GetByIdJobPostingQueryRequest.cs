using MediatR;

namespace HireWise.Application.Features.Queries.JobPosting.GetByIdJobPosting
{
    public class GetByIdJobPostingQueryRequest : IRequest<GetByIdJobPostingQueryResponse>
    {
        public string Id { get; set; }
    }
}
