using MediatR;

namespace HireWise.Application.Features.Commands.Language.UpdateLanguage
{
    public class UpdateLanguageCommandRequest : IRequest<UpdateLanguageCommandResponse>
    {
        public string Id { get; set; }
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ProficiencyLevel { get; set; }
    }
}
