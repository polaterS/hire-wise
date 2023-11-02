using MediatR;

namespace HireWise.Application.Features.Commands.Language.CreateLanguage
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommandRequest, CreateLanguageCommandResponse>
    {
        readonly ILanguageWriteRepository _languageWriteRepository;

        public CreateLanguageCommandHandler(ILanguageWriteRepository languageWriteRepository)
        {
            _languageWriteRepository = languageWriteRepository;
        }

        public async Task<CreateLanguageCommandResponse> Handle(CreateLanguageCommandRequest request, CancellationToken cancellationToken)
        {
            await _languageWriteRepository.AddAsync(new()
            {
                Name = request.Name,
                ProficiencyLevel = request.ProficiencyLevel,
                EmployeeId = request.EmployeeId,
            });
            await _languageWriteRepository.SaveAsync();

            return new();
        }
    }
}
