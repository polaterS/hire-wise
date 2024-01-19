using MediatR;

namespace HireWise.Application.Features.Commands.EmployeeLeaveDays.UpdateEmployeeLeaveDays
{
    public class UpdateEmployeeLeaveDaysCommandHandler : IRequestHandler<UpdateEmployeeLeaveDaysCommandRequest, UpdateEmployeeLeaveDaysCommandResponse>
    {
        IEmployeeLeaveDaysWriteRepository _employeeLeaveDaysWriteRepository;
        IEmployeeLeaveDaysReadRepository _employeeLeaveDaysReadRepository;

        public UpdateEmployeeLeaveDaysCommandHandler(IEmployeeLeaveDaysWriteRepository employeeLeaveDaysWriteRepository, IEmployeeLeaveDaysReadRepository employeeLeaveDaysReadRepository)
        {
            _employeeLeaveDaysWriteRepository = employeeLeaveDaysWriteRepository;
            _employeeLeaveDaysReadRepository = employeeLeaveDaysReadRepository;
        }

        public async Task<UpdateEmployeeLeaveDaysCommandResponse> Handle(UpdateEmployeeLeaveDaysCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.EmployeeLeaveDays employeeLeaveDays = await _employeeLeaveDaysReadRepository.GetByIdAsync(request.EmployeeLeaveDaysId);
            employeeLeaveDays.LeaveStartDate = request.LeaveStartDate;
            employeeLeaveDays.LeaveEndDate = request.LeaveEndDate;
            employeeLeaveDays.LeaveReason = request.LeaveReason;
            employeeLeaveDays.LeaveTypeName = request.LeaveTypeName;
            employeeLeaveDays.LeaveStatusName = request.LeaveStatusName;
            employeeLeaveDays.ApprovalComments = request.ApprovalComments;
            await _employeeLeaveDaysWriteRepository.SaveAsync();
            return new();
        }
    }
}
