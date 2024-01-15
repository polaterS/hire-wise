using MediatR;

namespace HireWise.Application.Features.Commands.SchoolExperience.CreateSchoolExperience
{
    public class CreateSchoolExperienceCommandRequest : IRequest<CreateSchoolExperienceCommandResponse>
    {
        public int EmployeeId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolType { get; set; }
        public decimal Grade { get; set; }
        public string SchoolDateOfStartOnUtc { get; set; }
        public string SchoolDateOfEndOnUtc { get; set; }
    }
}
