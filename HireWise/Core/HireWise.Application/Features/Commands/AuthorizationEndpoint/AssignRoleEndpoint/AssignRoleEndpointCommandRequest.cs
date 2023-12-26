using HireWise.Application.Dto;
using MediatR;

namespace HireWise.Application.Features.Commands.AuthorizationEndpoint.AssignRoleEndpoint
{
    public class AssignRoleEndpointCommandRequest : IRequest<AssignRoleEndpointCommandResponse>
    {
        public string[] Roles { get; set; }
        public string Code { get; set; }
        public string Menu { get; set; }
        public SimpleTypeDescriptor Type { get; set; }
    }
}
