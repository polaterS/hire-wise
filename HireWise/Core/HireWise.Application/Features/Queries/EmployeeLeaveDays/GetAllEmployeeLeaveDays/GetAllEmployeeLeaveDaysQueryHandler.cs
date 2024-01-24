using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetAllEmployeeLeaveDays
{
    public class GetAllEmployeeLeaveDaysQueryHandler : IRequestHandler<GetAllEmployeeLeaveDaysQueryRequest, GetAllEmployeeLeaveDaysQueryResponse>
    {
        IEmployeeLeaveDaysReadRepository _employeeLeaveDaysReadRepository;

        public GetAllEmployeeLeaveDaysQueryHandler(IEmployeeLeaveDaysReadRepository employeeLeaveDaysReadRepository)
        {
            _employeeLeaveDaysReadRepository = employeeLeaveDaysReadRepository;
        }

        public async Task<GetAllEmployeeLeaveDaysQueryResponse> Handle(GetAllEmployeeLeaveDaysQueryRequest request, CancellationToken cancellationToken)
        {
            var totalEmployeeLeaveDaysCount = _employeeLeaveDaysReadRepository.GetAll(false).Count();
            var employeeLeaveDays = _employeeLeaveDaysReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.LeaveStatusName,
                d.LeaveStartDate,
                d.LeaveEndDate,
                d.LeaveTypeName,
                d.LeaveReason,
            }).ToList();

            return new()
            {
                EmployeeLeaveDays = employeeLeaveDays,
                TotalEmployeeLeaveDaysCount = totalEmployeeLeaveDaysCount
            };
        }
    }
}
