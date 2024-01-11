using MediatR;

namespace HireWise.Application.Features.Queries.Language.GetAllLanguage
{
    public class GetAllLanguageQueryRequest : IRequest<GetAllLanguageQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
