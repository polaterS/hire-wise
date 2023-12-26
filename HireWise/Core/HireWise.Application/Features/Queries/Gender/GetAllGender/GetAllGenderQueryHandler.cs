using MediatR;

namespace HireWise.Application.Features.Queries.Gender.GetAllGender
{
    public class GetAllGenderQueryHandler : IRequestHandler<GetAllGenderQueryRequest, GetAllGenderQueryResponse>
    {
        readonly IGenderReadRepository _genderReadRepository;

        public GetAllGenderQueryHandler(IGenderReadRepository genderReadRepository)
        {
            _genderReadRepository = genderReadRepository;
        }

        public async Task<GetAllGenderQueryResponse> Handle(GetAllGenderQueryRequest request, CancellationToken cancellationToken)
        {
            var totalGenderCount = _genderReadRepository.GetAll(false).Count();
            var genders = _genderReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.Name
            }).ToList();

            return new()
            {
                Genders = genders,
                TotalGenderCount = totalGenderCount
            };
        }
    }
}
