using MediatR;

namespace HireWise.Application.Features.Commands.Family.RemoveFamily
{
    public class RemoveFamilyCommandRequest : IRequest<RemoveFamilyCommandResponse>
    {
        public string Id { get; set; }
    }
}
