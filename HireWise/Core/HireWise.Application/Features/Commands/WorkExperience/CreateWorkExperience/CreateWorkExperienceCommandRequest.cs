﻿using MediatR;

namespace HireWise.Application.Features.Commands.WorkExperience.CreateWorkExperience
{
    public class CreateWorkExperienceCommandRequest : IRequest<CreateWorkExperienceCommandResponse>
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }
        public string Departmant { get; set; }
        public string Position { get; set; }
        public string WorkDateOfStart { get; set; }
        public string WorkDateOfEnd { get; set; }
    }
}
