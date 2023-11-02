using MediatR;

namespace HireWise.Application.Features.Commands.Language.CreateLanguage
{
    public class CreateLanguageCommandRequest : IRequest<CreateLanguageCommandResponse>
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
