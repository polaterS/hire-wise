using MediatR;

namespace HireWise.Application.Features.Queries.AnnouncementAndNews.GetByIdAnnouncementAndNews
{
    public class GetByIdAnnouncementAndNewsQueryHandler : IRequestHandler<GetByIdAnnouncementAndNewsQueryRequest, GetByIdAnnouncementAndNewsQueryResponse>
    {
        IAnnouncementAndNewsReadRepository _announcementAndNewsReadRepository;

        public GetByIdAnnouncementAndNewsQueryHandler(IAnnouncementAndNewsReadRepository announcementAndNewsReadRepository)
        {
            _announcementAndNewsReadRepository = announcementAndNewsReadRepository;
        }

        public async Task<GetByIdAnnouncementAndNewsQueryResponse> Handle(GetByIdAnnouncementAndNewsQueryRequest request, CancellationToken cancellationToken)
        {
            HireWise.Domain.Entities.AnnouncementAndNews announcementAndNews = await _announcementAndNewsReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Header = announcementAndNews.Header,
                Content = announcementAndNews.Content,
            };
        }
    }
}
