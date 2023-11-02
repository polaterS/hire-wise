using HireWise.Application.Features.Commands.Family.CreateFamily;
using HireWise.Application.Features.Commands.Family.RemoveFamily;
using HireWise.Application.Features.Commands.Family.UpdateFamily;
using HireWise.Application.Features.Queries.Family.GetByIdFamily;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FamiliesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public FamiliesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("{familyId}")]
        public async Task<IActionResult> GetFamilyById(string familyId)
        {
            try
            {
                var response = await _mediator.Send(new GetByIdFamilyQueryRequest { Id = familyId });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateFamily(CreateFamilyCommandRequest request)
        {
            try
            {
                var response = await _mediator.Send(request);
                return StatusCode((int)HttpStatusCode.Created, response);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut("{familyId}")]
        public async Task<IActionResult> UpdateFamily(string familyId, UpdateFamilyCommandRequest request)
        {
            try
            {
                request.Id = familyId;
                var response = await _mediator.Send(request);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete("{familyId}")]
        public async Task<IActionResult> RemoveFamily(string familyId)
        {
            try
            {
                var response = await _mediator.Send(new RemoveFamilyCommandRequest { Id = familyId });
                return Ok(response);
            }
            catch (Exception ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
