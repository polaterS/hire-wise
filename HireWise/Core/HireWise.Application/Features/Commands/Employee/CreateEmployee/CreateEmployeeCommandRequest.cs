using HireWise.Application.Dto;
using MediatR;

namespace HireWise.Application.Features.Commands.Employee.CreateEmployee
{
    public class CreateEmployeeCommandRequest : IRequest<CreateEmployeeCommandResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
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
