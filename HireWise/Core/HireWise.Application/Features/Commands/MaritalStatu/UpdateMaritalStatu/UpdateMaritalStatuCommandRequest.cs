using MediatR;

namespace HireWise.Application.Features.Commands.MaritalStatu.UpdateMaritalStatu
{
    public class UpdateMaritalStatuCommandRequest : IRequest<UpdateMaritalStatuCommandResponse>
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }
}
