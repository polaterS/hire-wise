using MediatR;

namespace HireWise.Application.Features.Queries.Department.GetAllDepartment
{
    public class GetAllDepartmentQueryHandler : IRequestHandler<GetAllDepartmentQueryRequest, GetAllDepartmentQueryResponse>
    {
        readonly IDepartmentReadRepository _departmentReadRepository;

        public GetAllDepartmentQueryHandler(IDepartmentReadRepository departmentReadRepository)
        {
            _departmentReadRepository = departmentReadRepository;
        }

        public async Task<GetAllDepartmentQueryResponse> Handle(GetAllDepartmentQueryRequest request, CancellationToken cancellationToken)
        {
            var totalDepartmentCount = _departmentReadRepository.GetAll(false).Count();
            var departments = _departmentReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.Name,
            }).ToList();

            return new()
            {
                Departments = departments,
                TotalDepartmentCount = totalDepartmentCount
            };
        }
    }
}
