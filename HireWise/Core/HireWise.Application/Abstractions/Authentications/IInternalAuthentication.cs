namespace HireWise.Application.Abstractions.Authentications
{
    public interface IInternalAuthentication
    {
        Task<HireWise.Application.Dto.Token> LoginAsync(string email, string password, int accessTokenLifeTime);
        Task<HireWise.Application.Dto.Token> RefreshTokenLoginAsync(string refreshToken);
    }
}
