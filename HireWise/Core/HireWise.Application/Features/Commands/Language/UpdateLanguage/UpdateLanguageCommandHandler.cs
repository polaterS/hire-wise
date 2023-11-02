using MediatR;

namespace HireWise.Application.Features.Commands.Language.UpdateLanguage
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommandRequest, UpdateLanguageCommandResponse>
    {
        readonly ILanguageWriteRepository _languageWriteRepository;
        readonly ILanguageReadRepository _languageReadRepository;
        public UpdateLanguageCommandHandler(ILanguageWriteRepository languageWriteRepository, ILanguageReadRepository languageReadRepository)
        {
            _languageWriteRepository = languageWriteRepository;
            _languageReadRepository = languageReadRepository;
        }

        public async Task<UpdateLanguageCommandResponse> Handle(UpdateLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Language language = await _languageReadRepository.GetByIdAsync(request.Id);

            language.EmployeeId = request.EmployeeId;
            language.Name = request.Name;
            language.ProficiencyLevel = request.ProficiencyLevel;

            await _languageWriteRepository.SaveAsync();
            return new();
        }
    }
}
