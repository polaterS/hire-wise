using MediatR;

namespace HireWise.Application.Features.Queries.Employee.GetByIdEmployee
{
    public class GetByIdEmployeeQueryHandler : IRequestHandler<GetByIdEmployeeQueryRequest, GetByIdEmployeeQueryResponse>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        public GetByIdEmployeeQueryHandler(IEmployeeReadRepository employeeReadRepository)
        {
            _employeeReadRepository = employeeReadRepository;
        }

        public async Task<GetByIdEmployeeQueryResponse> Handle(GetByIdEmployeeQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Employee employee = await _employeeReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                Email = employee.Email,
                Phone = employee.Phone,
                DateOfBirth = employee.DateOfBirth,
                CitizenshipNumber = employee.CitizenshipNumber,
                DepartmentId = employee.DepartmentId,
                GenderId = employee.GenderId,
                MaritalStatuId = employee.MaritalStatuId
            };
        }
    }
}
