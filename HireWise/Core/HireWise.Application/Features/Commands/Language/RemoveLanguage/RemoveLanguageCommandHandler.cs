using MediatR;

namespace HireWise.Application.Features.Commands.Language.RemoveLanguage
{
    public class RemoveLanguageCommandHandler : IRequestHandler<RemoveLanguageCommandRequest, RemoveLanguageCommandResponse>
    {
        readonly ILanguageWriteRepository _languageWriteRepository;

        public RemoveLanguageCommandHandler(ILanguageWriteRepository languageWriteRepository)
        {
            _languageWriteRepository = languageWriteRepository;
        }

        public async Task<RemoveLanguageCommandResponse> Handle(RemoveLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            await _languageWriteRepository.RemoveAsync(request.Id);
            await _languageWriteRepository.SaveAsync();
            return new();
        }
    }
}
