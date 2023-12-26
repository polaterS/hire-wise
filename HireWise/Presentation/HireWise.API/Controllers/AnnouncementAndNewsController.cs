using HireWise.Application.Features.Commands.AnnouncementAndNews.CreateAnnouncementAndNews;
using HireWise.Application.Features.Commands.AnnouncementAndNews.RemoveAnnouncementAndNews;
using HireWise.Application.Features.Commands.AnnouncementAndNews.UpdateAnnouncementAndNews;
using HireWise.Application.Features.Queries.AnnouncementAndNews.GetAllAnnouncementAndNews;
using HireWise.Application.Features.Queries.AnnouncementAndNews.GetByIdAnnouncementAndNews;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnouncementAndNewsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AnnouncementAndNewsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllAnnouncementAndNewsQueryRequest request)
        {
            GetAllAnnouncementAndNewsQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdAnnouncementAndNewsQueryRequest request)
        {
            GetByIdAnnouncementAndNewsQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateAnnouncementAndNewsCommandRequest request)
        {
            CreateAnnouncementAndNewsCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateAnnouncementAndNewsCommandRequest request)
        {
            UpdateAnnouncementAndNewsCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveAnnouncementAndNewsCommandRequest request)
        {
            RemoveAnnouncementAndNewsCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
