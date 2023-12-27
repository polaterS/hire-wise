using HireWise.Application.Features.Commands.DepartmentReport.CreateDepartmentReport;
using HireWise.Application.Features.Commands.DepartmentReport.RemoveDepartmentReport;
using HireWise.Application.Features.Commands.DepartmentReport.UpdateDepartmentReport;
using HireWise.Application.Features.Commands.EmployeeReport.CreateEmployeeReport;
using HireWise.Application.Features.Commands.EmployeeReport.RemoveEmployeeReport;
using HireWise.Application.Features.Commands.EmployeeReport.UpdateEmployeeReport;
using HireWise.Application.Features.Queries.DepartmentReport.GetAllDepartmentReport;
using HireWise.Application.Features.Queries.DepartmentReport.GetByIdDepartmentReport;
using HireWise.Application.Features.Queries.EmployeeReport.GetAllEmployeeReport;
using HireWise.Application.Features.Queries.EmployeeReport.GetByIdEmployeeReport;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeReportsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeReportsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllEmployeeReportQueryRequest request)
        {
            GetAllEmployeeReportQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdEmployeeReportQueryRequest request)
        {
            GetByIdEmployeeReportQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateEmployeeReportCommandRequest request)
        {
            CreateEmployeeReportCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateEmployeeReportCommandRequest request)
        {
            UpdateEmployeeReportCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveEmployeeReportCommandRequest request)
        {
            RemoveEmployeeReportCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
