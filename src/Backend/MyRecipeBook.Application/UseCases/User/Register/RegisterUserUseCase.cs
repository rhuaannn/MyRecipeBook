using MyRecipeBook.Application.Services.Mapping;
using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using MyRecipeBook.Exception;
using MyRecipeBook.Exception.Exception;
using MyRecipeBook.Exception.ExceptionBase;


namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
        {
            Validate(request);

            var user = new UserMapping();
            return new ResponseRegisterUserJson
            {
            };
        }

        private void Validate(RequestRegisterUserJson request)
        {
            var validator = new UserValidation();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var messages = result.Errors.Select(e => e.ErrorMessage).ToList();
                throw new ErroOnValidationException(messages);
            }
        }
    }
}
