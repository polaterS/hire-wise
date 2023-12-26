using MediatR;

namespace HireWise.Application.Features.Commands.EventAndSeminar.RemoveEventAndSeminar
{
    public class RemoveEventAndSeminarCommandRequest : IRequest<RemoveEventAndSeminarCommandResponse>
    {
        public string EventAndSeminarId { get; set; }
    }
}
