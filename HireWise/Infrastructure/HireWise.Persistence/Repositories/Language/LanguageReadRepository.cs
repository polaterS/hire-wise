using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class LanguageReadRepository : ReadRepository<Language>, ILanguageReadRepository
    {
        public LanguageReadRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
