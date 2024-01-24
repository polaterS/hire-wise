namespace HireWise.Application.Features.Queries.EmployeeLeaveDays.GetByIdEmployeeLeaveDays
{
    public class GetByIdEmployeeLeaveDaysQueryResponse
    {
        public string LeaveStartDate { get; set; }

        public string LeaveEndDate { get; set; }

        public string LeaveReason { get; set; }

        public string LeaveTypeName { get; set; }

        public string LeaveStatusName { get; set; }
    }
}
