using MediatR;

namespace HireWise.Application.Features.Queries.Language.GetByIdLanguage
{
    public class GetByIdLanguageQueryHander : IRequestHandler<GetByIdLanguageQueryRequest, GetByIdLanguageQueryResponse>
    {
        readonly ILanguageReadRepository _languageReadRepository;

        public GetByIdLanguageQueryHander(ILanguageReadRepository languageReadRepository)
        {
            _languageReadRepository = languageReadRepository;
        }

        public async Task<GetByIdLanguageQueryResponse> Handle(GetByIdLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Language language = await _languageReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                EmployeeId = language.EmployeeId,
                LanguageEnum = language.LanguageEnum,
                ProficiencyLevel = language.ProficiencyLevel
            };
        }
    }
}
