using MediatR;

namespace HireWise.Application.Features.Commands.Department.CreateDepartment
{
    public class CreateDepartmentCommandRequest : IRequest<CreateDepartmentCommandResponse>
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
    }
}
