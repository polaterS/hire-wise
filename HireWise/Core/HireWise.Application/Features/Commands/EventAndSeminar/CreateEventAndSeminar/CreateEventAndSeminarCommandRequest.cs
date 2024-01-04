using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.CreateEventAndSeminar
{
    public class CreateEventAndSeminarCommandRequest : IRequest<CreateEventAndSeminarCommandResponse>
    {
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string Description { get; set; }
    }
}
