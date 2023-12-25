using FluentValidation;
using HireWise.Application.ViewModels.Employees;

namespace HireWise.Application.Validators.Employees
{
    public class Create_Employee_Validator : AbstractValidator<VM_Create_Employee>
    {
        public Create_Employee_Validator()
        {
            //RuleFor(e => e.FirstName)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Lütfen isim alanını boş geçmeyiniz.")
            //    .MaximumLength(100)
            //    .MinimumLength(2)
            //    .WithMessage("Lütfen isim alanına 2 ile 100 karakter arasında giriniz.");

            //RuleFor(e => e.LastName)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Lütfen soyisim alanını boş geçmeyiniz.")
            //    .MaximumLength(100)
            //    .MinimumLength(2)
            //    .WithMessage("Lütfen soyisim alanına 2 ile 100 karakter arasında giriniz.");

            //RuleFor(e => e.Email)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Lütfen email alanını boş geçmeyiniz.")
            //    .MaximumLength(100)
            //    .MinimumLength(5)
            //    .WithMessage("Lütfen email alanına 5 ile 100 karakter arasında giriniz.");

            //RuleFor(e => e.Phone)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Lütfen phone alanını boş geçmeyiniz.")
            //    .MaximumLength(20)
            //    .MinimumLength(5)
            //    .WithMessage("Lütfen phone alanına 5 ile 20 karakter arasında giriniz.");

            //RuleFor(e => e.CitizenshipNumber)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Lütfen citizenshipnumber alanını boş geçmeyiniz.")
            //    .MaximumLength(20)
            //    .MinimumLength(5)
            //    .WithMessage("Lütfen citizenshipnumber alanına 5 ile 20 karakter arasında giriniz.");

            //RuleFor(e => e.DateOfBirth)
            //    .NotEmpty()
            //    .NotNull()
            //    .WithMessage("Lütfen DateOfBirth alanını boş geçmeyiniz.");
        }
    }
}
