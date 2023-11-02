using MediatR;

namespace HireWise.Application.Features.Commands.Language.RemoveLanguage
{
    public class RemoveLanguageCommandRequest : IRequest<RemoveLanguageCommandResponse>
    {
        public string Id { get; set; }
    }
}
