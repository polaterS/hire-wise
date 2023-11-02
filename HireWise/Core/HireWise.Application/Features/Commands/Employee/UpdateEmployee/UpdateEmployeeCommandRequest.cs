using MediatR;

namespace HireWise.Application.Features.Commands.Employee.UpdateEmployee
{
    public class UpdateEmployeeCommandRequest : IRequest<UpdateEmployeeCommandResponse>
    {
        public string Id { get; set; }
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
