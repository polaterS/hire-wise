﻿namespace HireWise.Application.Features.Queries.SchoolExperience.GetByIdSchoolExperience
{
    public class GetByIdSchoolExperienceQueryResponse
    {
        public int EmployeeId { get; set; }
        public string SchoolName { get; set; }
        public string SchoolType { get; set; }
        public decimal Grade { get; set; }
        public string SchoolDateOfStartOnUtc { get; set; }
        public string SchoolDateOfEndOnUtc { get; set; }
    }
}
