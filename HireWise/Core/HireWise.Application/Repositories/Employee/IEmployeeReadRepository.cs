﻿using HireWise.Application.Repositories;
using HireWise.Domain.Entities;

namespace HireWise.Application
{
    public interface IEmployeeReadRepository : IReadRepository<Employee>
    {
    }
}
