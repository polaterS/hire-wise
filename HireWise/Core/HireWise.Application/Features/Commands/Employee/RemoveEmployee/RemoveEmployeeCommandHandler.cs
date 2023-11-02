using MediatR;

namespace HireWise.Application.Features.Commands.Employee.RemoveEmployee
{
    public class RemoveEmployeeCommandHandler : IRequestHandler<RemoveEmployeeCommandRequest, RemoveEmployeeCommandResponse>
    {
        readonly IEmployeeWriteRepository _employeeWriteRepository;

        public RemoveEmployeeCommandHandler(IEmployeeWriteRepository employeeWriteRepository)
        {
            _employeeWriteRepository = employeeWriteRepository;
        }

        public async Task<RemoveEmployeeCommandResponse> Handle(RemoveEmployeeCommandRequest request, CancellationToken cancellationToken)
        {
            await _employeeWriteRepository.RemoveAsync(request.Id);
            await _employeeWriteRepository.SaveAsync();
            return new();
        }
    }
}
