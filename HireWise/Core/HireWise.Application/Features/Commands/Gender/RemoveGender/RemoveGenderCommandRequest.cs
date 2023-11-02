using MediatR;

namespace HireWise.Application.Features.Commands.Gender.RemoveGender
{
    public class RemoveGenderCommandRequest : IRequest<RemoveGenderCommandResponse>
    {
        public string Id { get; set; }
    }
}
