using MediatR;

namespace HireWise.Application.Features.Queries.AnnouncementAndNews.GetAllAnnouncementAndNews
{
    public class GetAllAnnouncementAndNewsQueryRequest : IRequest<GetAllAnnouncementAndNewsQueryResponse>
    {
        public int Page { get; set; } = 0;
        public int Size { get; set; } = int.MaxValue;
    }
}
