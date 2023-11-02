using HireWise.Application.Features.Commands.Department.CreateDepartment;
using HireWise.Application.Features.Commands.Department.RemoveDepartment;
using HireWise.Application.Features.Commands.Department.UpdateDepartment;
using HireWise.Application.Features.Queries.Department.GetAllDepartment;
using HireWise.Application.Features.Queries.Department.GetByIdDepartment;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllDepartmentQueryRequest request)
        {
            GetAllDepartmentQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute] GetByIdDepartmentQueryRequest request)
        {
            GetByIdDepartmentQueryResponse response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost]
        public async Task<IActionResult> Post(CreateDepartmentCommandRequest request)
        {
            CreateDepartmentCommandResponse response = await _mediator.Send(request);
            return StatusCode((int)HttpStatusCode.Created);
        }

        [HttpPut]
        public async Task<IActionResult> Put(UpdateDepartmentCommandRequest request)
        {
            UpdateDepartmentCommandResponse response = await _mediator.Send(request);
            return Ok();
        }

        [HttpDelete("{Id}")]
        public async Task<IActionResult> Delete(RemoveDepartmentCommandRequest request)
        {
            RemoveDepartmentCommandResponse response = await _mediator.Send(request);
            return Ok();
        }
    }
}
