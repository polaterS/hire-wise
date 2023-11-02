using MediatR;

namespace HireWise.Application.Features.Queries.Employee.GetAllEmployee
{
    public class GetAllEmployeeQueryRequest : IRequest<GetAllEmployeeQueryResponse>
    {
        //public Pagination Pagination { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
