using System.Net;
using System.Runtime.Serialization;

namespace SpyDuh_Robin.Repositories
{
    [Serializable]
    internal class StatusCodeException : Exception
    {
        private HttpStatusCode notFound;

        public StatusCodeException()
        {
        }

        public StatusCodeException(HttpStatusCode notFound)
        {
            this.notFound = notFound;
        }

        public StatusCodeException(string? message) : base(message)
        {
        }

        public StatusCodeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected StatusCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}