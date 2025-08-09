using FluentValidation;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class UserValidation : AbstractValidator<RequestRegisterUserJson>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be null.");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password cannot be empty.");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email cannot be empty.");
        }
    }
}
