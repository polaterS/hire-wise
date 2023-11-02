using MediatR;

namespace HireWise.Application.Features.Commands.Gender.UpdateGender
{
    public class UpdateGenderCommandRequest : IRequest<UpdateGenderCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
