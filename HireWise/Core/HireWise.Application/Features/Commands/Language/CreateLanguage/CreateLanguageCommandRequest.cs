using HireWise.Domain.Enums;
using MediatR;

namespace HireWise.Application.Features.Commands.Language.CreateLanguage
{
    public class CreateLanguageCommandRequest : IRequest<CreateLanguageCommandResponse>
    {
        public int EmployeeId { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
