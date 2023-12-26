using MediatR;

namespace HireWise.Application.Features.Commands.AnnouncementAndNews.RemoveAnnouncementAndNews
{
    public class RemoveAnnouncementAndNewsCommandRequest : IRequest<RemoveAnnouncementAndNewsCommandResponse>
    {
        public string AnnouncementAndNewsId { get; set; }
    }
}
