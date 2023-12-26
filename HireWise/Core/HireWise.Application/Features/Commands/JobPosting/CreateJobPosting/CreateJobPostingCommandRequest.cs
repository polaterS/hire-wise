using MediatR;

namespace HireWise.Application.Features.Commands.JobPosting.CreateJobPosting
{
    public class CreateJobPostingCommandRequest : IRequest<CreateJobPostingCommandResponse>
    {
        public string Position { get; set; }
        public string CompanyName { get; set; }
        public string Experience { get; set; }
        public string Location { get; set; }
        public string Operation { get; set; } // Örneğin: Tam zamanlı, yarı zamanlı, sözleşmeli, uzaktan vb.
        public string Description { get; set; }
        public string Qualifications { get; set; }
        public string Benefits { get; set; }
        public DateTime ApplicationDeadline { get; set; }
    }
}
