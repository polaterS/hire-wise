using MediatR;

namespace HireWise.Application.Features.Queries.Department.GetByIdDepartment
{
    public class GetByIdDepartmentQueryHandler : IRequestHandler<GetByIdDepartmentQueryRequest, GetByIdDepartmentQueryResponse>
    {
        readonly IDepartmentReadRepository _departmentReadRepository;

        public GetByIdDepartmentQueryHandler(IDepartmentReadRepository departmentReadRepository)
        {
            _departmentReadRepository = departmentReadRepository;
        }

        public async Task<GetByIdDepartmentQueryResponse> Handle(GetByIdDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Department department = await _departmentReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = department.Name,
                Salary = department.Salary,
                Position = department.Position,
                HireDate = department.HireDate,
                TerminationDate = department.TerminationDate,
            };
        }
    }
}
