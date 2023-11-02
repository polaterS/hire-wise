using MediatR;

namespace HireWise.Application.Features.Queries.Language.GetByIdLanguage
{
    public class GetByIdLanguageQueryRequest : IRequest<GetByIdLanguageQueryResponse>
    {
        public string Id { get; set; }
    }
}
