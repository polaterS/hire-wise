using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetAllEmployeeLeaveDays
{
    public class GetAllEmployeeLeaveDaysQueryRequest : IRequest<GetAllEmployeeLeaveDaysQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
