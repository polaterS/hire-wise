﻿using HireWise.Application.Dto;

namespace HireWise.Application.Features.Queries.Employee.GetByIdEmployee
{
    public class GetByIdEmployeeQueryResponse
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string CitizenshipNumber { get; set; }
        public int DepartmentId { get; set; }
        public int GenderId { get; set; }
        public int MaritalStatuId { get; set; }
        public int? PositionId { get; set; }
        //public List<EmployeeImageFileDto> EmployeeImageFiles { get; set; }
        public List<LanguageDto>? Languages { get; set; }
        public List<AddressDto>? Addresses { get; set; }
        public List<FamilyDto>? Families { get; set; }
        public List<SchoolExperienceDto>? SchoolExperiences { get; set; }
        public List<WorkExperienceDto>? WorkExperiences { get; set; }
    }
}
