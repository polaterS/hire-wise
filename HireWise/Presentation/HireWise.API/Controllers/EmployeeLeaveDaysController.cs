using HireWise.Application.Features.Commands.Department.CreateDepartment;
using HireWise.Application.Features.Commands.Department.RemoveDepartment;
using HireWise.Application.Features.Commands.Department.UpdateDepartment;
using HireWise.Application.Features.Commands.EmployeeLeaveDays.CreateEmployeeLeaveDays;
using HireWise.Application.Features.Commands.EmployeeLeaveDays.RemoveEmployeeLeaveDays;
using HireWise.Application.Features.Commands.EmployeeLeaveDays.UpdateEmployeeLeaveDays;
using HireWise.Application.Features.Queries.Department.GetAllDepartment;
using HireWise.Application.Features.Queries.Department.GetByIdDepartment;
using HireWise.Application.Features.Queries.EmployeeLeaveDays.GetAllEmployeeLeaveDays;
using HireWise.Application.Features.Queries.EmployeeLeaveDays.GetByIdEmployeeLeaveDays;
using HireWise.Application.Features.Queries.EmployeeLeaveDays.GetEmployeeLeaveDaysByEmployee;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeLeaveDaysController : ControllerBase
    {
        private readonly IMediator _mediator;

        public EmployeeLeaveDaysController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllEmployeeLeaveDaysQueryRequest request)
        {
            GetAllEmployeeLeaveDaysQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdEmployeeLeaveDaysQueryRequest request)
        {
            GetByIdEmployeeLeaveDaysQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("ByEmployee/{employeeId}")]
        public async Task<IActionResult> GetEmployeeLeaveDaysByEmployee([FromRoute] int employeeId)
        {
            var query = new GetEmployeeLeaveDaysByEmployeeQuery { EmployeeId = employeeId };
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateEmployeeLeaveDaysCommandRequest request)
        {
            CreateEmployeeLeaveDaysCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateEmployeeLeaveDaysCommandRequest request)
        {
            UpdateEmployeeLeaveDaysCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveEmployeeLeaveDaysCommandRequest request)
        {
            RemoveEmployeeLeaveDaysCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
