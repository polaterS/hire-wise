using MediatR;
using Microsoft.AspNetCore.Http;

namespace HireWise.Application.Features.Commands.EmployeeImageFile.UploadEmployeeImage
{
    public class UploadEmployeeImageCommandRequest : IRequest<UploadEmployeeImageCommandResponse>
    {
        public string Id { get; set; }
        public IFormFileCollection? Files { get; set; }
    }
}
