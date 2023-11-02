using MediatR;

namespace HireWise.Application.Features.Commands.MaritalStatu.RemoveMaritalStatu
{
    public class RemoveMaritalStatuCommandRequest : IRequest<RemoveMaritalStatuCommandResponse>
    {
        public string Id { get; set; }
    }
}
