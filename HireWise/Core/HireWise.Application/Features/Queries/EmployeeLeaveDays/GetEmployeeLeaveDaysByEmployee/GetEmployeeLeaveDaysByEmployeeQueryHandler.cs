using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using HireWise.Application.Dto;
using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetEmployeeLeaveDaysByEmployee
{
    public class GetEmployeeLeaveDaysByEmployeeQueryHandler : IRequestHandler<GetEmployeeLeaveDaysByEmployeeQuery, List<EmployeeLeaveDaysDto>>
    {
        private readonly IEmployeeLeaveDaysReadRepository _repository;

        public GetEmployeeLeaveDaysByEmployeeQueryHandler(IEmployeeLeaveDaysReadRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<EmployeeLeaveDaysDto>> Handle(GetEmployeeLeaveDaysByEmployeeQuery request, CancellationToken cancellationToken)
        {
            var leaveDaysEntities = await _repository.GetByEmployeeIdAsync(request.EmployeeId);

            var leaveDaysDtos = leaveDaysEntities.Select(ld => new EmployeeLeaveDaysDto
            {
                LeaveStartDate = ld.LeaveStartDate,
                LeaveEndDate = ld.LeaveEndDate,
                LeaveReason = ld.LeaveReason,
                LeaveTypeName = ld.LeaveTypeName,
                LeaveStatusName = ld.LeaveStatusName
            }).ToList();

            return leaveDaysDtos;
        }



    }
}
