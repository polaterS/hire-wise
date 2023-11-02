using HireWise.Application.Repositories;
using HireWise.Domain.Entities;

namespace HireWise.Application
{
    public interface IEmployeeWriteRepository : IWriteRepository<Employee>
    {
    }
}
