using HireWise.Application.Abstractions.Authentications;

namespace HireWise.Application.Abstractions.Services
{
    public interface IAuthService : IExternalAuthentication, IInternalAuthentication
    {
    }
}
