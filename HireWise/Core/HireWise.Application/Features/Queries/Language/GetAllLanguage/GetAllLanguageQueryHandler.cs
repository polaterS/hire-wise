using MediatR;

namespace HireWise.Application.Features.Queries.Language.GetAllLanguage
{
    public class GetAllLanguageQueryHandler : IRequestHandler<GetAllLanguageQueryRequest, GetAllLanguageQueryResponse>
    {
        readonly ILanguageReadRepository _languageReadRepository;

        public GetAllLanguageQueryHandler(ILanguageReadRepository languageReadRepository)
        {
            _languageReadRepository = languageReadRepository;
        }

        public async Task<GetAllLanguageQueryResponse> Handle(GetAllLanguageQueryRequest request, CancellationToken cancellationToken)
        {
            var languages = _languageReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(e => new
            {
                e.Id,
                e.LanguageEnum,
                e.ProficiencyLevel
            }).ToList();
            var totalLanguageCount = languages.Count;

            return new()
            {
                Languages = languages,
                TotalLanguageCount = totalLanguageCount
            };
        }
    }
}
