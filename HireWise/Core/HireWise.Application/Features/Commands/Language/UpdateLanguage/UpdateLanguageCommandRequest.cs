using HireWise.Domain.Enums;
using MediatR;

namespace HireWise.Application.Features.Commands.Language.UpdateLanguage
{
    public class UpdateLanguageCommandRequest : IRequest<UpdateLanguageCommandResponse>
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public LanguageEnum LanguageEnum { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
