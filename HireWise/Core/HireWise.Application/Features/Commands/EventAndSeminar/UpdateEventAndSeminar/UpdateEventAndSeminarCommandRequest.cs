using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.UpdateEventAndSeminar
{
    public class UpdateEventAndSeminarCommandRequest : IRequest<UpdateEventAndSeminarCommandResponse>
    {
        public string EventAndSeminarId { get; set; }
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
