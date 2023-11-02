namespace HireWise.Application.ViewModels.Employees
{
    public class VM_Create_Employee
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
    }
}
