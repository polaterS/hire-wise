﻿using HireWise.Domain.Entities.Common;

namespace HireWise.Domain.Entities
{
    public class SchoolExperience : BaseEntity
    {
        public int EmployeeId { get; set; }

        public string SchoolName { get; set; }

        public string SchoolType { get; set; }

        public decimal Grade { get; set; }

        public string SchoolDateOfStartOnUtc { get; set; }

        public string SchoolDateOfEndOnUtc { get; set; }

        public Employee Employee { get; set; }
    }
}
