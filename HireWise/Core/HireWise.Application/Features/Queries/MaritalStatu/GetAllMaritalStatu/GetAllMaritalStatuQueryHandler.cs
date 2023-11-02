using MediatR;

namespace HireWise.Application.Features.Queries.MaritalStatu.GetAllMaritalStatu
{
    public class GetAllMaritalStatuQueryHandler : IRequestHandler<GetAllMaritalStatuQueryRequest, GetAllMaritalStatuQueryResponse>
    {
        readonly IMaritalStatuReadRepository _maritalStatuReadRepository;

        public GetAllMaritalStatuQueryHandler(IMaritalStatuReadRepository maritalStatuReadRepository)
        {
            _maritalStatuReadRepository = maritalStatuReadRepository;
        }

        public async Task<GetAllMaritalStatuQueryResponse> Handle(GetAllMaritalStatuQueryRequest request, CancellationToken cancellationToken)
        {
            var totalMaritalStatuCount = _maritalStatuReadRepository.GetAll(false).Count();
            var maritalStatus = _maritalStatuReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.Name
            }).ToList();

            return new()
            {
                MaritalStatus = maritalStatus,
                TotalMaritalStatuCount = totalMaritalStatuCount
            };
        }
    }
}
