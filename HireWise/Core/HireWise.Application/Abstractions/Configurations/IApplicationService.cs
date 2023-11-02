using HireWise.Application.Dto.Configuration;

namespace HireWise.Application.Abstractions.Configurations
{
    public interface IApplicationService
    {
        List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
    }
}
