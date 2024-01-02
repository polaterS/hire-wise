using MediatR;

namespace HireWise.Application.Features.Queries.Department.GetAllDepartment
{
    public class GetAllDepartmentQueryRequest : IRequest<GetAllDepartmentQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
