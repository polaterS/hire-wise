using HireWise.Application;
using HireWise.Application.Abstractions.Storage;
using HireWise.Application.Consts;
using HireWise.Application.CutomAttributes;
using HireWise.Application.Enums;
using HireWise.Application.Features.Commands.Employee.AddRoleEmployee;
using HireWise.Application.Features.Commands.Employee.CreateEmployee;
using HireWise.Application.Features.Commands.Employee.RemoveEmployee;
using HireWise.Application.Features.Commands.Employee.UpdateEmployee;
using HireWise.Application.Features.Commands.EmployeeImageFile.RemoveEmployeeImage;
using HireWise.Application.Features.Commands.EmployeeImageFile.UploadEmployeeImage;
using HireWise.Application.Features.Queries.Employee.GetAllEmployee;
using HireWise.Application.Features.Queries.Employee.GetByIdEmployee;
using HireWise.Application.Features.Queries.EmployeeImageFile.GetEmployeeImages;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace HireWise.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class EmployeesController : ControllerBase
    {
        readonly private IEmployeeWriteRepository _employeeWriteRepository;
        readonly private IEmployeeReadRepository _employeeReadRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;
        readonly IFileWriteRepostiory _fileWriteRepostiory;
        readonly IFileReadRepostiory _fileReadRepostiory;
        readonly IEmployeeImageFileWriteRepository _employeeImageFileWriteRepository;
        readonly IEmployeeImageFileReadRepository _employeeImageFileReadRepository;
        readonly IStorageService _storageService;
        readonly IConfiguration _configuration;
        readonly IMediator _mediator;

        public EmployeesController(
            IEmployeeWriteRepository employeeWriteRepository,
            IEmployeeReadRepository employeeReadRepository,
            IWebHostEnvironment webHostEnvironment,
            IFileWriteRepostiory fileWriteRepostiory,
            IFileReadRepostiory fileReadRepostiory,
            IEmployeeImageFileWriteRepository employeeImageFileWriteRepository,
            IEmployeeImageFileReadRepository employeeImageFileReadRepository,
            IStorageService storageService,
            IConfiguration configuration,
            IMediator mediator)
        {
            _employeeWriteRepository = employeeWriteRepository;
            _employeeReadRepository = employeeReadRepository;
            this._webHostEnvironment = webHostEnvironment;
            _fileWriteRepostiory = fileWriteRepostiory;
            _fileReadRepostiory = fileReadRepostiory;
            _employeeImageFileWriteRepository = employeeImageFileWriteRepository;
            _employeeImageFileReadRepository = employeeImageFileReadRepository;
            _storageService = storageService;
            _configuration = configuration;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllEmployeeQueryRequest getAllEmployeeQueryRequest)
        {
            GetAllEmployeeQueryResponse response = await _mediator.Send(getAllEmployeeQueryRequest);
            return Ok(response);
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> Get([FromRoute]GetByIdEmployeeQueryRequest getByIdEmployeeQueryRequest)
        {
            GetByIdEmployeeQueryResponse response = await _mediator.Send(getByIdEmployeeQueryRequest);
            return Ok(response);
        }

        //[Authorize(AuthenticationSchemes = "Admin")]
        //[AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Writing, Definition = "Create Employee")]
        [HttpPost]
        public async Task<IActionResult> Post(CreateEmployeeCommandRequest createEmployeeCommandRequest)
        {
            CreateEmployeeCommandResponse response = await _mediator.Send(createEmployeeCommandRequest);
            return StatusCode((int)HttpStatusCode.Created);    
        }

        [HttpPut]
        //[Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Updating, Definition = "Update Employee")]
        public async Task<IActionResult> Put([FromBody]UpdateEmployeeCommandRequest updateEmployeeCommandRequest)
        {
            UpdateEmployeeCommandResponse response = await _mediator.Send(updateEmployeeCommandRequest);
            return Ok();
        }

        [HttpDelete("{Id}")]
        //[Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Deleting, Definition = "Delete Employee")]
        public async Task<IActionResult> Delete([FromRoute] RemoveEmployeeCommandRequest removeEmployeeCommandRequest)
        {
            RemoveEmployeeCommandResponse response = await _mediator.Send(removeEmployeeCommandRequest);
            return Ok();
        }

        [HttpPost("[action]")]
        //[Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Writing, Definition = "Upload Employee File")]
        public async Task<IActionResult> Upload([FromQuery] UploadEmployeeImageCommandRequest uploadEmployeeImageCommandRequest)
        {
            uploadEmployeeImageCommandRequest.Files = Request.Form.Files;
            UploadEmployeeImageCommandResponse response = await _mediator.Send(uploadEmployeeImageCommandRequest);
            return Ok();
        }

        [HttpGet("[Action]/{id}")]
        //[Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Reading, Definition = "Get Employee Images")]
        public async Task<IActionResult> GetEmployeeImages([FromRoute] GetEmployeeImagesQueryRequest getEmployeeImagesQueryRequest)
        {
            List<GetEmployeeImagesQueryResponse> response = await _mediator.Send(getEmployeeImagesQueryRequest);
            return Ok(response);
        }

        [HttpDelete("[Action]/{Id}")]
        //[Authorize(AuthenticationSchemes = "Admin")]
        [AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Deleting, Definition = "Delete Employee Image")]
        public async Task<IActionResult> DeleteEmployeeImage([FromRoute] RemoveEmployeeImageCommandRequest removeEmployeeImageCommandRequest, [FromQuery] string imageId)
        {
            removeEmployeeImageCommandRequest.ImageId = imageId;
            RemoveEmployeeImageCommandResponse response = await _mediator.Send(removeEmployeeImageCommandRequest);
            return Ok();
        }

        //[HttpPost]
        //[Authorize(AuthenticationSchemes = "Admin")]
        //[AuthorizeDefinition(Menu = AuthorizeDefinitionConstants.Employees, ActionType = ActionType.Writing, Definition = "Add Role Employee")]
        //public async Task<IActionResult> EmployeeAddRole(AddRoleEmployeeCommandRequest request)
        //{
        //    AddRoleEmployeeCommandResponse response = await _mediator.Send(request);
        //    return StatusCode((int)HttpStatusCode.Created);
        //}
    }
}