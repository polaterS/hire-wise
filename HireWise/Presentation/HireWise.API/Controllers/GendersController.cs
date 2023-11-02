using HireWise.Application.Features.Commands.Gender.CreateGender;
using HireWise.Application.Features.Commands.Gender.RemoveGender;
using HireWise.Application.Features.Commands.Gender.UpdateGender;
using HireWise.Application.Features.Queries.Gender.GetAllGender;
using HireWise.Application.Features.Queries.Gender.GetByIdGender;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GendersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GendersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllGenderQueryRequest request)
        {
            GetAllGenderQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdGenderQueryRequest request)
        {
            GetByIdGenderQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateGenderCommandRequest request)
        {
            CreateGenderCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateGenderCommandRequest request)
        {
            UpdateGenderCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveGenderCommandRequest request)
        {
            RemoveGenderCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
