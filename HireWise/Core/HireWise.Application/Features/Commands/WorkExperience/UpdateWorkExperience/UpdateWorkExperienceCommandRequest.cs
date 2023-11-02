using MediatR;

namespace HireWise.Application.Features.Commands.WorkExperience.UpdateWorkExperience
{
    public class UpdateWorkExperienceCommandRequest : IRequest<UpdateWorkExperienceCommandResponse>
    {
        public string WorkExperienceId { get; set; }
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Departmant { get; set; }
        public string Position { get; set; }
        public DateTime WorkDateOfStart { get; set; }
        public DateTime? WorkDateOfEnd { get; set; }
    }
}
