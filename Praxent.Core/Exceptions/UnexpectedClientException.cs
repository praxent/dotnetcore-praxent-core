using System;
using System.Net.Http;

namespace Praxent.Core.Exceptions
{
    public class UnexpectedClientException : ApiException
    {
        public UnexpectedClientException() : base("An error occurred when requested data from remote API.") { }
        public UnexpectedClientException(HttpResponseMessage response) : 
            base(String.Format("An error occurred when requested data from remote API: {0}, Endpoint URI {1}, {2}", response.StatusCode, response.RequestMessage.RequestUri, response.Content.ReadAsStringAsync().Result) ) { }
    }
}
