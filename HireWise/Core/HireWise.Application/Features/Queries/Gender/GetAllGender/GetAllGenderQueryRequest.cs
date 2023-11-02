using MediatR;

namespace HireWise.Application.Features.Queries.Gender.GetAllGender
{
    public class GetAllGenderQueryRequest : IRequest<GetAllGenderQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}
