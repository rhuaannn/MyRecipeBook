using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;


namespace MyRecipeBook.Application.UseCases.User.Register
{
    public class RegisterUserUseCase
    {
        public ResponseRegisterUserJson Execute(RequestRegisterUserJson request)
        {
            Validate(request);

            return new ResponseRegisterUserJson
            {
                Name = request.Name
            };
        }

        private void Validate(RequestRegisterUserJson request)
        {
            var validator = new UserValidation();
            var result = validator.Validate(request);

            if (!result.IsValid)
            {
                var messages = string.Join("; ", result.Errors.Select(e => e.ErrorMessage));
                throw new Exception(messages);
            }
        }
    }
}
