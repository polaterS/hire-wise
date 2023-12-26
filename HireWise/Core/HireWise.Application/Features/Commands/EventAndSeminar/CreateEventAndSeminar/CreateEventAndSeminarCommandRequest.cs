using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.CreateEventAndSeminar
{
    public class CreateEventAndSeminarCommandRequest : IRequest<CreateEventAndSeminarCommandResponse>
    {
        public string Name { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
    }
}
