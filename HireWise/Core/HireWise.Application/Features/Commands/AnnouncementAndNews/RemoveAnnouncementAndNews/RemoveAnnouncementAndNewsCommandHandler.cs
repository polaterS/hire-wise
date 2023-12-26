using MediatR;

namespace HireWise.Application.Features.Commands.AnnouncementAndNews.RemoveAnnouncementAndNews
{
    public class RemoveAnnouncementAndNewsCommandHandler : IRequestHandler<RemoveAnnouncementAndNewsCommandRequest, RemoveAnnouncementAndNewsCommandResponse>
    {
        IAnnouncementAndNewsWriteRepository _announcementAndNewsWriteRepository;

        public RemoveAnnouncementAndNewsCommandHandler(IAnnouncementAndNewsWriteRepository announcementAndNewsWriteRepository)
        {
            _announcementAndNewsWriteRepository = announcementAndNewsWriteRepository;
        }

        public async Task<RemoveAnnouncementAndNewsCommandResponse> Handle(RemoveAnnouncementAndNewsCommandRequest request, CancellationToken cancellationToken)
        {
            await _announcementAndNewsWriteRepository.RemoveAsync(request.AnnouncementAndNewsId);
            await _announcementAndNewsWriteRepository.SaveAsync();
            return new();
        }
    }
}
