using HireWise.Domain.Entities.Identity;

namespace HireWise.Application.Abstractions.Token
{
    public interface ITokenHandler
    {
        Dto.Token CreateAccessToken(int second, AppUser appUser);
        string CreateRefreshToken();
    }
}
