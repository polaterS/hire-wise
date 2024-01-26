using HireWise.Application.Repositories;
using HireWise.Domain.Entities.Common;
using HireWise.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace HireWise.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly HireWiseDbContext _context;

        public ReadRepository(HireWiseDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        //=> await Table.FirstOrDefaultAsync(data => data.Id == int.Parse(id));
        //=> await Table.FindAsync(id);
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = Table.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == int.Parse(id));
        }

        public async Task<List<T>> GetByEmployeeIdAsync(int employeeId, bool tracking = true)
        {
            var propertyInfo = typeof(T).GetProperty("EmployeeId");
            if (propertyInfo != null)
            {
                var query = _context.Set<T>().AsQueryable();

                if (!tracking)
                {
                    query = query.AsNoTracking();
                }

                // "EmployeeId" özelliğine göre filtreleme yapmak için dinamik bir yaklaşım
                var parameter = Expression.Parameter(typeof(T), "e");
                var property = Expression.Property(parameter, "EmployeeId");
                var constant = Expression.Constant(employeeId);
                var comparison = Expression.Equal(property, constant);
                var lambda = Expression.Lambda<Func<T, bool>>(comparison, parameter);

                return await query.Where(lambda).ToListAsync();
            }
            else
            {
                throw new InvalidOperationException("This entity does not support EmployeeId filtering.");
            }
        }


    }
}
