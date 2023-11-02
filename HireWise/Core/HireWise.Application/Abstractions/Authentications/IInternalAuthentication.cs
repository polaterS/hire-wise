namespace HireWise.Application.Abstractions.Authentications
{
    public interface IInternalAuthentication
    {
        Task<HireWise.Application.Dto.Token> LoginAsync(string usernameOrEmail, string password, int accessTokenLifeTime);
        Task<HireWise.Application.Dto.Token> RefreshTokenLoginAsync(string refreshToken);
    }
}
