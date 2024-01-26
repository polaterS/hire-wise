using HireWise.Application.Dto;
using MediatR;

namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetEmployeeLeaveDaysByEmployee
{
    public class GetEmployeeLeaveDaysByEmployeeQuery : IRequest<List<EmployeeLeaveDaysDto>>
    {
        public int EmployeeId { get; set; }
    }
}