using MediatR;

namespace HireWise.Application.Features.Queries.Department.GetByIdDepartment
{
    public class GetByIdDepartmentQueryRequest : IRequest<GetByIdDepartmentQueryResponse>
    {
        public string Id { get; set; }
    }
}
