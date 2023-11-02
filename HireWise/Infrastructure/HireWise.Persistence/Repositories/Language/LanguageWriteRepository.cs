using HireWise.Application;
using HireWise.Domain.Entities;
using HireWise.Persistence.Context;
using HireWise.Persistence.Repositories;

namespace HireWise.Persistence
{
    public class LanguageWriteRepository : WriteRepository<Language>, ILanguageWriteRepository
    {
        public LanguageWriteRepository(HireWiseDbContext context) : base(context)
        {
        }
    }
}
