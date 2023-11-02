using HireWise.Application.Features.Commands.Address.CreateAddress;
using HireWise.Application.Features.Commands.Address.RemoveAddress;
using HireWise.Application.Features.Commands.Address.UpdateAddress;
using HireWise.Application.Features.Queries.Address.GetByIdAddress;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AddressesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                var query = new GetByIdAddressQueryRequest { AddressId = id };
                var result = await _mediator.Send(query);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateAddressCommandRequest createAddressCommandRequest)
        {
            CreateAddressCommandResponse response = await _mediator.Send(createAddressCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete([FromRoute] RemoveAddressCommandRequest removeAddressCommandRequest)
        {
            RemoveAddressCommandResponse response = await _mediator.Send(removeAddressCommandRequest);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put([FromRoute] string id, [FromBody] UpdateAddressCommandRequest updateAddressCommandRequest)
        {
            updateAddressCommandRequest.AddressId = id;
            UpdateAddressCommandResponse response = await _mediator.Send(updateAddressCommandRequest);
            return Ok();
        }
    }
}
