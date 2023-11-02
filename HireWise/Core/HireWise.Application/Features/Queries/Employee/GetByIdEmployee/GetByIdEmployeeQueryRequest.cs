using MediatR;

namespace HireWise.Application.Features.Queries.Employee.GetByIdEmployee
{
    public class GetByIdEmployeeQueryRequest : IRequest<GetByIdEmployeeQueryResponse>
    {
        public string Id { get; set; }
    }
}
