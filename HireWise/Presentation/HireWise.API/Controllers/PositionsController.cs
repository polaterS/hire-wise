using HireWise.Application.Features.Commands.Position.CreatePosition;
using HireWise.Application.Features.Commands.Position.RemovePosition;
using HireWise.Application.Features.Commands.Position.UpdatePosition;
using HireWise.Application.Features.Queries.Position.GetAllPosition;
using HireWise.Application.Features.Queries.Position.GetByIdPosition;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PositionsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PositionsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllPositionQueryRequest request)
        {
            GetAllPositionQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdPositionQueryRequest request)
        {
            GetByIdPositionQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreatePositionCommandRequest request)
        {
            CreatePositionCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdatePositionCommandRequest request)
        {
            UpdatePositionCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemovePositionCommandRequest request)
        {
            RemovePositionCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
