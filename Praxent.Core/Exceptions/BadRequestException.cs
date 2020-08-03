using System.Collections.Generic;

namespace Praxent.Core.Exceptions
{
    public class BadRequestException : ApiException
    {
        public BadRequestException() { }
        public BadRequestException(string message) : base(message) { }

        public BadRequestException(string validationKey, string validationMessage)
        {
            Data.Add(validationKey, validationMessage);
        }

        public BadRequestException(IDictionary<string, string> validationErrors)
        {
            foreach (var error in validationErrors)
            {
                Data.Add(error.Key, error.Value);
            }
        }
    }
}
