using MediatR;

namespace HireWise.Application.Features.Commands.SchoolExperience.UpdateSchoolExperience
{
    public class UpdateSchoolExperienceCommandRequest : IRequest<UpdateSchoolExperienceCommandResponse>
    {
        public string SchoolExperienceId { get; set; }
        public int EmployeeId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolType { get; set; }
        public decimal Grade { get; set; }
        public DateTime SchoolDateOfStartOnUtc { get; set; }
        public DateTime? SchoolDateOfEndOnUtc { get; set; }
    }
}
