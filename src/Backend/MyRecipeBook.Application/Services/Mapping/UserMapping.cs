using MyRecipeBook.Communication.Requests;
using MyRecipeBook.Communication.Responses;
using MyRecipeBook.Domain.Entites;

namespace MyRecipeBook.Application.Services.Mapping
{
    public class UserMapping
    {
        public User RequestToDomain(RequestRegisterUserJson request)
        {
            return new User
            {
                Name = request.Name,
                Email = request.Email,
                Password = HashPassword(request.Password)
            };
        }
        public ResponseRegisterUserJson DomainToResponse(User user)
        {
            return new ResponseRegisterUserJson
            {
                Name = user.Name
            };
        }
        private string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}