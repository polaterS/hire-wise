﻿using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class EmployeeReportReadRepository : ReadRepository<EmployeeReport>, IEmployeeReportReadRepository
    {
        public EmployeeReportReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
