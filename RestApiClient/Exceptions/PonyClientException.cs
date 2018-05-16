using System;

namespace RestApiClient.Exceptions
{
    public class PonyClientException : Exception
    {
        public PonyClientException(string text) : base(text)
        {
        }
    }
}