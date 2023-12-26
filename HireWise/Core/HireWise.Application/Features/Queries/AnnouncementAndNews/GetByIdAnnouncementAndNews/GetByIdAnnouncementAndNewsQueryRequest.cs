using MediatR;

namespace HireWise.Application.Features.Queries.AnnouncementAndNews.GetByIdAnnouncementAndNews
{
    public class GetByIdAnnouncementAndNewsQueryRequest : IRequest<GetByIdAnnouncementAndNewsQueryResponse>
    {
        public string Id { get; set; }
    }
}
