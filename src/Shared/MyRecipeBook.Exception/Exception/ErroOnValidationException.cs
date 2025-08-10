using MyRecipeBook.Exception.ExceptionBase;

namespace MyRecipeBook.Exception.Exception
{
    public class ErroOnValidationException : MyRecipeExceptionBase
    {
        public IList<string> Errors { get; set; }
        public ErroOnValidationException(IList<string> errors)
        {
            Errors = errors;
        }
    }
}
