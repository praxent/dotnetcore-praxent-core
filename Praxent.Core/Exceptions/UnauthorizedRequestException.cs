
namespace Praxent.Core.Exceptions
{
    public class UnauthorizedRequestException : ApiException
    {
        public UnauthorizedRequestException() : base("Invalid Request: No Current User can be located. Please ensure a User is currently Logged In.") { }
        public UnauthorizedRequestException(string message) : base(message) { }
    }
}
