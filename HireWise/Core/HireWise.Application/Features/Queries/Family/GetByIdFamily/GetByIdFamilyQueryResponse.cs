namespace HireWise.Application.Features.Queries.Family.GetByIdFamily
{
    public class GetByIdFamilyQueryResponse
    {
        public int EmployeeId { get; set; }
        public string FamilyType { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAlive { get; set; }
    }
}
