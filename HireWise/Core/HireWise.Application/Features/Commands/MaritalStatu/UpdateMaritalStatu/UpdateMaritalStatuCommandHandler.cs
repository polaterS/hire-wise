using MediatR;

namespace HireWise.Application.Features.Commands.MaritalStatu.UpdateMaritalStatu
{
    public class UpdateMaritalStatuCommandHandler : IRequestHandler<UpdateMaritalStatuCommandRequest, UpdateMaritalStatuCommandResponse>
    {
        readonly IMaritalStatuWriteRepository _maritalStatuWriteRepository;
        readonly IMaritalStatuReadRepository _maritalStatuReadRepository;

        public UpdateMaritalStatuCommandHandler(IMaritalStatuWriteRepository maritalStatuWriteRepository, IMaritalStatuReadRepository maritalStatuReadRepository)
        {
            _maritalStatuWriteRepository = maritalStatuWriteRepository;
            _maritalStatuReadRepository = maritalStatuReadRepository;
        }

        public async Task<UpdateMaritalStatuCommandResponse> Handle(UpdateMaritalStatuCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.MaritalStatu maritalStatu = await _maritalStatuReadRepository.GetByIdAsync(request.Id);
            maritalStatu.Name = request.Name;
            await _maritalStatuWriteRepository.SaveAsync();
            return new();
        }
    }
}
