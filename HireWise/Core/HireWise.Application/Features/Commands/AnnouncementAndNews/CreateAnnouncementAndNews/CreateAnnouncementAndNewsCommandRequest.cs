using MediatR;

namespace HireWise.Application.Features.Commands.AnnouncementAndNews.CreateAnnouncementAndNews
{
    public class CreateAnnouncementAndNewsCommandRequest : IRequest<CreateAnnouncementAndNewsCommandResponse>
    {
        public string Header { get; set; }
        public string Content { get; set; }
    }
}
