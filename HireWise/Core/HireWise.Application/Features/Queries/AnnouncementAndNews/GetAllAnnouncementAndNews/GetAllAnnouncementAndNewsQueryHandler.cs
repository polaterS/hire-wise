using MediatR;

namespace HireWise.Application.Features.Queries.AnnouncementAndNews.GetAllAnnouncementAndNews
{
    public class GetAllAnnouncementAndNewsQueryHandler : IRequestHandler<GetAllAnnouncementAndNewsQueryRequest, GetAllAnnouncementAndNewsQueryResponse>
    {
        IAnnouncementAndNewsReadRepository _announcementAndNewsReadRepository;

        public GetAllAnnouncementAndNewsQueryHandler(IAnnouncementAndNewsReadRepository announcementAndNewsReadRepository)
        {
            _announcementAndNewsReadRepository = announcementAndNewsReadRepository;
        }

        public async Task<GetAllAnnouncementAndNewsQueryResponse> Handle(GetAllAnnouncementAndNewsQueryRequest request, CancellationToken cancellationToken)
        {
            var totalAnnouncementAndNewsCount = _announcementAndNewsReadRepository.GetAll(false).Count();
            var announcementAndNews = _announcementAndNewsReadRepository.GetAll(false).Skip(request.Page * request.Size).Take(request.Size)
            .Select(d => new
            {
                d.Id,
                d.Header,
                d.Content,
            }).ToList();

            return new()
            {
                AnnouncementAndNews = announcementAndNews,
                TotalAnnouncementAndNewsCount = totalAnnouncementAndNewsCount
            };
        }
    }
}
