using MediatR;

namespace HireWise.Application.Features.Commands.Gender.CreateGender
{
    public class CreateGenderCommandRequest : IRequest<CreateGenderCommandResponse>
    {
        public string Name { get; set; }
    }
}
