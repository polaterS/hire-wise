using MediatR;

namespace HireWise.Application.Features.Commands.Employee.UpdateEmployee
{
    public class UpdateEmployeeCommandHandler : IRequestHandler<UpdateEmployeeCommandRequest, UpdateEmployeeCommandResponse>
    {
        readonly IEmployeeReadRepository _employeeReadRepository;
        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public UpdateEmployeeCommandHandler(IEmployeeReadRepository employeeReadRepository, IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeReadRepository = employeeReadRepository;
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<UpdateEmployeeCommandResponse> Handle(UpdateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Employee employee = await _employeeReadRepository.GetByIdAsync(request.Id);
            employee.FirstName = request.FirstName;
            employee.LastName = request.LastName;
            employee.Email = request.Email;
            employee.Phone = request.Phone;
            employee.DateOfBirth = request.DateOfBirth;
            employee.CitizenshipNumber = request.CitizenshipNumber;
            employee.DepartmentId = request.DepartmentId;
            employee.GenderId = request.GenderId;
            employee.MaritalStatuId = request.MaritalStatuId;
            await _employeeWriteRepository.SaveAsync();
            return new();
        }
    }
}
