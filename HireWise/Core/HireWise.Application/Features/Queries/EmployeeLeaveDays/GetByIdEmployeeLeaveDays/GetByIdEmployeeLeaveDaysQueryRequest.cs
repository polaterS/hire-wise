using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetByIdEmployeeLeaveDays
{
    public class GetByIdEmployeeLeaveDaysQueryRequest : IRequest<GetByIdEmployeeLeaveDaysQueryResponse>
    {
        public string Id { get; set; }
    }
}
