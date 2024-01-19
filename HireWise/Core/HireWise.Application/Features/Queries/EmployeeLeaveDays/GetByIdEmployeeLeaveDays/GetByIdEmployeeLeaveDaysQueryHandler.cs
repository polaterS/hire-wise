using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetByIdEmployeeLeaveDays
{
    public class GetByIdEmployeeLeaveDaysQueryHandler : IRequestHandler<GetByIdEmployeeLeaveDaysQueryRequest, GetByIdEmployeeLeaveDaysQueryResponse>
    {
        IEmployeeLeaveDaysReadRepository _employeeLeaveDaysReadRepository;

        public GetByIdEmployeeLeaveDaysQueryHandler(IEmployeeLeaveDaysReadRepository employeeLeaveDaysReadRepository)
        {
            _employeeLeaveDaysReadRepository = employeeLeaveDaysReadRepository;
        }

        public async Task<GetByIdEmployeeLeaveDaysQueryResponse> Handle(GetByIdEmployeeLeaveDaysQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.EmployeeLeaveDays employeeLeaveDays = await _employeeLeaveDaysReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                LeaveStartDate = employeeLeaveDays.LeaveStartDate,
                LeaveEndDate = employeeLeaveDays.LeaveEndDate,
                LeaveReason = employeeLeaveDays.LeaveReason,
                LeaveTypeName = employeeLeaveDays.LeaveTypeName,
                LeaveStatusName = employeeLeaveDays.LeaveStatusName,
                ApprovalComments = employeeLeaveDays.ApprovalComments
            };
        }
    }
}
