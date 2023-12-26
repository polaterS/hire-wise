using MediatR;

namespace HireWise.Application.Features.Commands.AnnouncementAndNews.UpdateAnnouncementAndNews
{
    public class UpdateAnnouncementAndNewsCommandRequest : IRequest<UpdateAnnouncementAndNewsCommandResponse>
    {
        public string AnnouncementAndNewsId { get; set; }
        public string Header { get; set; }
        public string Content { get; set; }
    }
}
