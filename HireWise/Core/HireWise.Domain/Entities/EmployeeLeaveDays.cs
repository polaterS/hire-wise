using System;
using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class EmployeeLeaveDays : BaseEntity
    {
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        // İznin başlangıç tarihi
        public string LeaveStartDate { get; set; }

        // İznin bitiş tarihi
        public string LeaveEndDate { get; set; }

        // İzin almanın sebebi
        public string LeaveReason { get; set; }

        // İzin türünü (yıllık, hastalık, ücretsiz)
        public string LeaveTypeName { get; set; }

        // İzin talebinin mevcut durumunu (beklemede, onaylandı, reddedildi)
        public string LeaveStatusName { get; set; }

    }
}
