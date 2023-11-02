namespace HireWise.Application.Features.Queries.Department.GetByIdDepartment
{
    public class GetByIdDepartmentQueryResponse
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
    }
}
