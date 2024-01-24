using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeLeaveDays.CreateEmployeeLeaveDays
{
    public class CreateEmployeeLeaveDaysCommandHandler : IRequestHandler<CreateEmployeeLeaveDaysCommandRequest, CreateEmployeeLeaveDaysCommandResponse>
    {
        IEmployeeLeaveDaysWriteRepository _employeeLeaveDaysWriteRepository;

        public CreateEmployeeLeaveDaysCommandHandler(IEmployeeLeaveDaysWriteRepository employeeLeaveDaysWriteRepository)
        {
            _employeeLeaveDaysWriteRepository = employeeLeaveDaysWriteRepository;
        }

        public async Task<CreateEmployeeLeaveDaysCommandResponse> Handle(CreateEmployeeLeaveDaysCommandRequest request, CancellationToken cancellationToken)
        {
            await _employeeLeaveDaysWriteRepository.AddAsync(new()
            {
                EmployeeId = request.EmployeeId,
                LeaveStartDate = request.LeaveStartDate,
                LeaveEndDate = request.LeaveEndDate,
                LeaveReason = request.LeaveReason,
                LeaveTypeName = request.LeaveTypeName,
                LeaveStatusName = request.LeaveStatusName,
            });
            await _employeeLeaveDaysWriteRepository.SaveAsync();

            return new();
        }
    }
}
