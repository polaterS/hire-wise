using MediatR;

namespace HireWise.Application.Features.Commands.Employee.CreateEmployee
{
    public class CreateEmployeeCommandHandler : IRequestHandler<CreateEmployeeCommandRequest, CreateEmployeeCommandResponse>
    {

        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public CreateEmployeeCommandHandler(IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<CreateEmployeeCommandResponse> Handle(CreateEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            await _employeeWriteRepository.AddAsync(new()
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Phone = request.Phone,
                DateOfBirth = request.DateOfBirth,
                CitizenshipNumber = request.CitizenshipNumber,
                DepartmentId = request.DepartmentId,
                GenderId = request.GenderId,
                MaritalStatuId = request.MaritalStatuId,
            });
            await _employeeWriteRepository.SaveAsync();

            return new();
        }
    }
}
