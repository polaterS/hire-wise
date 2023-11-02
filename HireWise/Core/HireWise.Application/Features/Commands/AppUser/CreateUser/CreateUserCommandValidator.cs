using FluentValidation;

namespace HireWise.Application.Features.Commands.AppUser.CreateUser
{
    public class CreateUserCommandValidator : AbstractValidator<CreateUserCommandRequest>
    {
        public CreateUserCommandValidator()
        {
            RuleFor(e => e.NameSurname)
              .NotEmpty()
              .WithMessage("Lütfen isim alanını boş geçmeyiniz.");

            RuleFor(e => e.Username)
              .NotEmpty()
              .WithMessage("Lütfen isim alanını boş geçmeyiniz.");

            RuleFor(e => e.Email)
              .NotEmpty()
              .WithMessage("Lütfen isim alanını boş geçmeyiniz.");

            RuleFor(p => p.Password).Matches(@"[A-Z]").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(p => p.Password).Matches(@"[a-z]").WithMessage("Your password must contain at least one lowercase letter.");
            RuleFor(p => p.Password).Matches(@"[0-9]").WithMessage("Your password must contain at least one number.");
            RuleFor(p => p.Password).Matches(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!?\*\.]).+$")
            .WithMessage("Your password must contain at least one uppercase letter, one lowercase letter, one number, and one of these special characters: !?*.");

            RuleFor(p => p.PasswordConfirm).Matches(@"[A-Z]").WithMessage("Your password must contain at least one uppercase letter.");
            RuleFor(p => p.PasswordConfirm).Matches(@"[a-z]").WithMessage("Your password must contain at least one lowercase letter.");
            RuleFor(p => p.PasswordConfirm).Matches(@"[0-9]").WithMessage("Your password must contain at least one number.");
            RuleFor(p => p.PasswordConfirm).Matches(@"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[!?\*\.]).+$")
            .WithMessage("Your password confirmation must contain at least one uppercase letter, one lowercase letter, one number, and one of these special characters: !?*.");


        }
    }
}
