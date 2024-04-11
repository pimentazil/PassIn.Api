namespace PassIn.Exceptions
{
    public class ErrorOrValidationException : PassInException
    {
        public ErrorOrValidationException(string message) : base(message)
        {
        }
    }
}
