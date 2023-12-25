using MediatR;

namespace HireWise.Application.Features.Commands.AppUser.LoginUser
{
    public class LoginUserCommandRequest : IRequest<LoginUserCommandResponse>
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
    }
}
