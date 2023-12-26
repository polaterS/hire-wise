using HireWise.Application.Features.Commands.JobPosting.CreateJobPosting;
using HireWise.Application.Features.Commands.JobPosting.RemoveJobPosting;
using HireWise.Application.Features.Commands.JobPosting.UpdateJobPosting;
using HireWise.Application.Features.Commands.Position.CreatePosition;
using HireWise.Application.Features.Commands.Position.RemovePosition;
using HireWise.Application.Features.Commands.Position.UpdatePosition;
using HireWise.Application.Features.Queries.JobPosting.GetAllJobPosting;
using HireWise.Application.Features.Queries.JobPosting.GetByIdJobPosting;
using HireWise.Application.Features.Queries.Position.GetAllPosition;
using HireWise.Application.Features.Queries.Position.GetByIdPosition;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobPostingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public JobPostingsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllJobPostingQueryRequest request)
        {
            GetAllJobPostingQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdJobPostingQueryRequest request)
        {
            GetByIdJobPostingQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateJobPostingCommandRequest request)
        {
            CreateJobPostingCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateJobPostingCommandRequest request)
        {
            UpdateJobPostingCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveJobPostingCommandRequest request)
        {
            RemoveJobPostingCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
