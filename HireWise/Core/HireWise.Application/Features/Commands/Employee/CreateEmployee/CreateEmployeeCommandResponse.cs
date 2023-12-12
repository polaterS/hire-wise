namespace HireWise.Application.Features.Commands.Employee.CreateEmployee
{
    public class CreateEmployeeCommandResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public int? EmployeeId { get; set; }
    }
}
