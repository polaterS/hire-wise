using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeLeaveDays.RemoveEmployeeLeaveDays
{
    public class RemoveEmployeeLeaveDaysCommandHandler : IRequestHandler<RemoveEmployeeLeaveDaysCommandRequest, RemoveEmployeeLeaveDaysCommandResponse>
    {
        IEmployeeLeaveDaysWriteRepository _employeeLeaveDaysWriteRepository;

        public RemoveEmployeeLeaveDaysCommandHandler(IEmployeeLeaveDaysWriteRepository employeeLeaveDaysWriteRepository)
        {
            _employeeLeaveDaysWriteRepository = employeeLeaveDaysWriteRepository;
        }

        public async Task<RemoveEmployeeLeaveDaysCommandResponse> Handle(RemoveEmployeeLeaveDaysCommandRequest request, CancellationToken cancellationToken)
        {
            await _employeeLeaveDaysWriteRepository.RemoveAsync(request.EmployeeLeaveDaysId);
            await _employeeLeaveDaysWriteRepository.SaveAsync();
            return new();
        }
    }
}
