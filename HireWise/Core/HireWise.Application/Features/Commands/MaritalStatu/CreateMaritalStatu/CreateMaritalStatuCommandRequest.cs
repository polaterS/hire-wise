using MediatR;

namespace HireWise.Application.Features.Commands.MaritalStatu.CreateMaritalStatu
{
    public class CreateMaritalStatuCommandRequest : IRequest<CreateMaritalStatuCommandResponse>
    {
        public string Name { get; set; }
    }
}
