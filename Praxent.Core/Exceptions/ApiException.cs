
namespace Praxent.Core.Exceptions
{
    public abstract class ApiException : System.Exception
    {
        protected ApiException() { }
        protected ApiException(string message) : base(message) { }
    }
}
