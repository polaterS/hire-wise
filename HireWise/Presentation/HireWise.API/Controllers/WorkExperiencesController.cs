using HireWise.Application.Features.Commands.WorkExperience.CreateWorkExperience;
using HireWise.Application.Features.Commands.WorkExperience.RemoveWorkExperience;
using HireWise.Application.Features.Commands.WorkExperience.UpdateWorkExperience;
using HireWise.Application.Features.Queries.WorkExperience.GetByIdWorkExperience;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkExperiencesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WorkExperiencesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdWorkExperienceQueryRequest request)
        {
            GetByIdWorkExperienceQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateWorkExperienceCommandRequest request)
        {
            CreateWorkExperienceCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateWorkExperienceCommandRequest request)
        {
            UpdateWorkExperienceCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveWorkExperienceCommandRequest request)
        {
            RemoveWorkExperienceCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
