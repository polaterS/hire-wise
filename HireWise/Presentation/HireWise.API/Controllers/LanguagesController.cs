using HireWise.Application.Features.Commands.Language.CreateLanguage;
using HireWise.Application.Features.Commands.Language.RemoveLanguage;
using HireWise.Application.Features.Commands.Language.UpdateLanguage;
using HireWise.Application.Features.Queries.Language.GetByIdLanguage;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LanguagesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdLanguageQueryRequest request)
        {
            GetByIdLanguageQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateLanguageCommandRequest request)
        {
            CreateLanguageCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateLanguageCommandRequest request)
        {
            UpdateLanguageCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveLanguageCommandRequest request)
        {
            RemoveLanguageCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
