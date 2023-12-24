using MediatR;

namespace HireWise.Application.Features.Queries.Employee.GetAllEmployee
{
    public class GetAllEmployeeQueryHandler : IRequestHandler<GetAllEmployeeQueryRequest, GetAllEmployeeQueryResponse>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        public GetAllEmployeeQueryHandler(IEmployeeReadRepository employeeReadRepository)
        {
            _employeeReadRepository = employeeReadRepository;
        }
        public async Task<GetAllEmployeeQueryResponse> Handle(GetAllEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            var employees = _employeeReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(e => new
            {
                e.Id,
                e.FirstName,
                e.LastName,
                e.Email,
                e.Phone,
                e.DateOfBirth,
                e.CitizenshipNumber,
                e.CreatedDate,
                e.UpdatedDate,
            }).ToList();
            var totalEmployeeCount = employees.Count;

            return new()
            {
                Employees = employees,
                TotalEmployeeCount = totalEmployeeCount
            };
        }
    }
}
