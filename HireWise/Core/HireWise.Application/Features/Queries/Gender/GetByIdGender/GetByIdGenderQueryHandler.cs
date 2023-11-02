using MediatR;

namespace HireWise.Application.Features.Queries.Gender.GetByIdGender
{
    public class GetByIdGenderQueryHandler : IRequestHandler<GetByIdGenderQueryRequest, GetByIdGenderQueryResponse>
    {
        readonly IGenderReadRepository _genderReadRepository;

        public GetByIdGenderQueryHandler(IGenderReadRepository genderReadRepository)
        {
            _genderReadRepository = genderReadRepository;
        }

        public async Task<GetByIdGenderQueryResponse> Handle(GetByIdGenderQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.Gender gender = await _genderReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = gender.Name
            };
        }
    }
}
