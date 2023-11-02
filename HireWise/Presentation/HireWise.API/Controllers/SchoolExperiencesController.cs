using HireWise.Application.Features.Commands.SchoolExperience.CreateSchoolExperience;
using HireWise.Application.Features.Commands.SchoolExperience.RemoveSchoolExperience;
using HireWise.Application.Features.Commands.SchoolExperience.UpdateSchoolExperience;
using HireWise.Application.Features.Queries.SchoolExperience.GetByIdSchoolExperience;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchoolExperiencesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SchoolExperiencesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdSchoolExperienceQueryRequest request)
        {
            GetByIdSchoolExperienceQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateSchoolExperienceCommandRequest request)
        {
            CreateSchoolExperienceCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateSchoolExperienceCommandRequest request)
        {
            UpdateSchoolExperienceCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveSchoolExperienceCommandRequest request)
        {
            RemoveSchoolExperienceCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
