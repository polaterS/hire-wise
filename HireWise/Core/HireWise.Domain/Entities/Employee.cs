using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string DateOfBirth { get; set; }
        public string CitizenshipNumber { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int GenderId { get; set; }
        public Gender Gender { get; set; }
        public int? PositionId { get; set; }
        public Position Position { get; set; }
        public int MaritalStatuId { get; set; }
        public MaritalStatu MaritalStatu { get; set; }
        public ICollection<EmployeeImageFile> EmployeeImageFiles { get; set; }
        public ICollection<Language> Languages { get; set; }
        public ICollection<Address> Addresses { get; set; }
        public ICollection<Family> Families { get; set; }
        public ICollection<SchoolExperience> SchoolExperiences { get; set; }
        public ICollection<WorkExperience> WorkExperiences { get; set; }
    }
}
