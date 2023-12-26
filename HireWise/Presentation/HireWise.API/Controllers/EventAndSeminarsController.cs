using HireWise.Application.Features.Commands.EventAndSeminar.CreateEventAndSeminar;
using HireWise.Application.Features.Commands.EventAndSeminar.RemoveEventAndSeminar;
using HireWise.Application.Features.Commands.EventAndSeminar.UpdateEventAndSeminar;
using HireWise.Application.Features.Queries.EventAndSeminar.GetAllEventAndSeminar;
using HireWise.Application.Features.Queries.EventAndSeminar.GetByIdEventAndSeminar;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventAndSeminarsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EventAndSeminarsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllEventAndSeminarQueryRequest request)
        {
            GetAllEventAndSeminarQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdEventAndSeminarQueryRequest request)
        {
            GetByIdEventAndSeminarQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateEventAndSeminarCommandRequest request)
        {
            CreateEventAndSeminarCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateEventAndSeminarCommandRequest request)
        {
            UpdateEventAndSeminarCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveEventAndSeminarCommandRequest request)
        {
            RemoveEventAndSeminarCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
