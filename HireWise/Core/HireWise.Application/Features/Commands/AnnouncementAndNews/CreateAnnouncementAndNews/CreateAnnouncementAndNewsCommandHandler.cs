using MediatR;

namespace HireWise.Application.Features.Commands.AnnouncementAndNews.CreateAnnouncementAndNews
{
    public class CreateAnnouncementAndNewsCommandHandler : IRequestHandler<CreateAnnouncementAndNewsCommandRequest, CreateAnnouncementAndNewsCommandResponse>
    {
        IAnnouncementAndNewsWriteRepository _announcementAndNewsWriteRepository;

        public CreateAnnouncementAndNewsCommandHandler(IAnnouncementAndNewsWriteRepository announcementAndNewsWriteRepository)
        {
            _announcementAndNewsWriteRepository = announcementAndNewsWriteRepository;
        }

        public async Task<CreateAnnouncementAndNewsCommandResponse> Handle(CreateAnnouncementAndNewsCommandRequest request, CancellationToken cancellationToken)
        {
            await _announcementAndNewsWriteRepository.AddAsync(new()
            {
                Header = request.Header,
                Content = request.Content
            });
            await _announcementAndNewsWriteRepository.SaveAsync();

            return new();
        }
    }
}
