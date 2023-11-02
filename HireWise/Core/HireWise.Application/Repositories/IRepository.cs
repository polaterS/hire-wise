using HireWise.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace HireWise.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        DbSet<T> Table { get; }
    }
}
