using MediatR;

namespace HireWise.Application.Features.Queries.MaritalStatu.GetByIdMaritalStatu
{
    public class GetByIdMaritalStatuQueryHandler : IRequestHandler<GetByIdMaritalStatuQueryRequest, GetByIdMaritalStatuQueryResponse>
    {
        readonly IMaritalStatuReadRepository _maritalStatuReadRepository;

        public GetByIdMaritalStatuQueryHandler(IMaritalStatuReadRepository maritalStatuReadRepository)
        {
            _maritalStatuReadRepository = maritalStatuReadRepository;
        }

        public async Task<GetByIdMaritalStatuQueryResponse> Handle(GetByIdMaritalStatuQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.MaritalStatu maritalStatu = await _maritalStatuReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = maritalStatu.Name
            };
        }
    }
}
