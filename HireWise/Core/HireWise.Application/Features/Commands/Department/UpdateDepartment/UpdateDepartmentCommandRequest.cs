using MediatR;

namespace HireWise.Application.Features.Commands.Department.UpdateDepartment
{
    public class UpdateDepartmentCommandRequest : IRequest<UpdateDepartmentCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
    }
}
