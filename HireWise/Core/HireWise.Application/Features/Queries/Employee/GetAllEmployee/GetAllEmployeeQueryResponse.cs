using HireWise.Domain.Entities.Identity;

namespace HireWise.Application.Features.Queries.Employee.GetAllEmployee
{
    public class GetAllEmployeeQueryResponse
    {
        public int TotalEmployeeCount { get; set; }
        public object Employees { get; set; }
    }
}
