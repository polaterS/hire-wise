using MediatR;

namespace HireWise.Application.Features.Queries.Gender.GetByIdGender
{
    public class GetByIdGenderQueryRequest : IRequest<GetByIdGenderQueryResponse>
    {
        public string Id { get; set; }
    }
}
