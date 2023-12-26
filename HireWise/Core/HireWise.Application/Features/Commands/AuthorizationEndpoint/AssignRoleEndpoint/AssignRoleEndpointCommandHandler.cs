using HireWise.Application.Abstractions.Services;
using MediatR;
using System;
using System.Reflection;

namespace HireWise.Application.Features.Commands.AuthorizationEndpoint.AssignRoleEndpoint
{
    public class AssignRoleEndpointCommandHandler : IRequestHandler<AssignRoleEndpointCommandRequest, AssignRoleEndpointCommandResponse>
    {
        readonly IAuthorizationEndpointService _authorizationEndpointService;

        public AssignRoleEndpointCommandHandler(IAuthorizationEndpointService authorizationEndpointService)
        {
            _authorizationEndpointService = authorizationEndpointService;
        }

        public async Task<AssignRoleEndpointCommandResponse> Handle(AssignRoleEndpointCommandRequest request, CancellationToken cancellationToken)
        {
            // Dönüşüm yapın
            Type type = Type.GetType(request.Type.TypeName);

            if (type == null)
            {
                // Uygun hata işleme veya varsayılan değer atama
                throw new InvalidOperationException("Verilen tip adı geçerli bir Type'a çözülemedi.");
            }

            // Dönüştürülmüş tipi kullanarak metod çağırımı yapın
            await _authorizationEndpointService.AssignRoleEndpointAsync(request.Roles, request.Menu, request.Code, type);
            return new AssignRoleEndpointCommandResponse();
        }
    }
}
