using HireWise.Application.Features.Commands.MaritalStatu.CreateMaritalStatu;
using HireWise.Application.Features.Commands.MaritalStatu.RemoveMaritalStatu;
using HireWise.Application.Features.Commands.MaritalStatu.UpdateMaritalStatu;
using HireWise.Application.Features.Queries.MaritalStatu.GetAllMaritalStatu;
using HireWise.Application.Features.Queries.MaritalStatu.GetByIdMaritalStatu;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaritalStatusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MaritalStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllMaritalStatuQueryRequest request)
        {
            GetAllMaritalStatuQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdMaritalStatuQueryRequest request)
        {
            GetByIdMaritalStatuQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateMaritalStatuCommandRequest request)
        {
            CreateMaritalStatuCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateMaritalStatuCommandRequest request)
        {
            UpdateMaritalStatuCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveMaritalStatuCommandRequest request)
        {
            RemoveMaritalStatuCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
