using MediatR;

namespace HireWise.Application.Features.Commands.AnnouncementAndNews.UpdateAnnouncementAndNews
{
    public class UpdateAnnouncementAndNewsCommandHandler : IRequestHandler<UpdateAnnouncementAndNewsCommandRequest, UpdateAnnouncementAndNewsCommandResponse>
    {
        IAnnouncementAndNewsWriteRepository _announcementAndNewsWriteRepository;
        IAnnouncementAndNewsReadRepository _announcementAndNewsReadRepository;

        public UpdateAnnouncementAndNewsCommandHandler(IAnnouncementAndNewsWriteRepository announcementAndNewsWriteRepository, IAnnouncementAndNewsReadRepository announcementAndNewsReadRepository)
        {
            _announcementAndNewsWriteRepository = announcementAndNewsWriteRepository;
            _announcementAndNewsReadRepository = announcementAndNewsReadRepository;
        }

        public async Task<UpdateAnnouncementAndNewsCommandResponse> Handle(UpdateAnnouncementAndNewsCommandRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.AnnouncementAndNews announcementAndNews = await _announcementAndNewsReadRepository.GetByIdAsync(request.AnnouncementAndNewsId);
            announcementAndNews.Header = request.Header;
            announcementAndNews.Content = request.Content;
            await _announcementAndNewsWriteRepository.SaveAsync();
            return new();
        }
    }
}
