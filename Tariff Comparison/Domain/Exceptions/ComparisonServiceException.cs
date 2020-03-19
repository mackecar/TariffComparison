using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationCore.Exceptions
{
    public class ComparisonServiceException : Exception
    {
        public ComparisonServiceException()
        {
        }

        public ComparisonServiceException(string message) : base(message)
        {
        }

        public ComparisonServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ComparisonServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
