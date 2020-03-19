using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationCore.Exceptions
{
    public class ProductUsageServiceException : Exception
    {
        public ProductUsageServiceException()
        {
        }

        public ProductUsageServiceException(string message) : base(message)
        {
        }

        public ProductUsageServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductUsageServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
