using MediatR;

namespace HireWise.Application.Features.Queries.Family.GetByIdFamily
{
    public class GetByIdFamilyQueryHandler : IRequestHandler<GetByIdFamilyQueryRequest, GetByIdFamilyQueryResponse>
    {
        readonly IFamilyReadRepository _familyReadRepository;

        public GetByIdFamilyQueryHandler(IFamilyReadRepository familyReadRepository)
        {
            _familyReadRepository = familyReadRepository;
        }

        public async Task<GetByIdFamilyQueryResponse> Handle(GetByIdFamilyQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Family family = await _familyReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                EmployeeId = family.EmployeeId,
                FirstName = family.FirstName,
                LastName = family.LastName,
                FamilyType = family.FamilyType,
                IsAlive = family.IsAlive,
            };
        }
    }
}
