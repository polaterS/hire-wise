using HireWise.Application.Features.Commands.DepartmentReport.CreateDepartmentReport;
using HireWise.Application.Features.Commands.DepartmentReport.RemoveDepartmentReport;
using HireWise.Application.Features.Commands.DepartmentReport.UpdateDepartmentReport;
using HireWise.Application.Features.Queries.DepartmentReport.GetAllDepartmentReport;
using HireWise.Application.Features.Queries.DepartmentReport.GetByIdDepartmentReport;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentReportsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllDepartmentReportQueryRequest request)
        {
            GetAllDepartmentReportQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdDepartmentReportQueryRequest request)
        {
            GetByIdDepartmentReportQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateDepartmentReportCommandRequest request)
        {
            CreateDepartmentReportCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateDepartmentReportCommandRequest request)
        {
            UpdateDepartmentReportCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveDepartmentReportCommandRequest request)
        {
            RemoveDepartmentReportCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
