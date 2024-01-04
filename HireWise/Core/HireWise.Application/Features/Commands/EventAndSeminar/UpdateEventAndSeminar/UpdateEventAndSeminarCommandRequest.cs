using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.UpdateEventAndSeminar
{
    public class UpdateEventAndSeminarCommandRequest : IRequest<UpdateEventAndSeminarCommandResponse>
    {
        public string EventAndSeminarId { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventLocation { get; set; }
        public string Description { get; set; }
    }
}
