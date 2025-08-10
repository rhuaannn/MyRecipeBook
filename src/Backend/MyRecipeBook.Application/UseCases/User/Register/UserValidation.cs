using FluentValidation;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Exception;

namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class UserValidation : AbstractValidator<RequestRegisterUserJson>
    {
        public UserValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).WithMessage(ResourceMessageException.NAME_EMPTY);
            RuleFor(x => x.Password.Length).GreaterThanOrEqualTo(6).WithMessage(ResourceMessageException.PASSWORD);
            RuleFor(x => x.Email).NotEmpty().EmailAddress().WithMessage(ResourceMessageException.EMAIL_EMPTY);
        }
    }
}
