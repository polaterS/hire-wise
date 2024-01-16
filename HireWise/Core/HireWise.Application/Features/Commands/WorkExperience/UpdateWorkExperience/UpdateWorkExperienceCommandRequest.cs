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
        public string WorkDateOfStart { get; set; }
        public string WorkDateOfEnd { get; set; }
    }
}
