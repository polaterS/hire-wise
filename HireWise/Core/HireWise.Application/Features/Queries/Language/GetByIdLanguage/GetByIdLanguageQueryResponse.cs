using HireWise.Domain.Enums;

namespace HireWise.Application.Features.Queries.Language.GetByIdLanguage
{
    public class GetByIdLanguageQueryResponse
    {
        public int EmployeeId { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
