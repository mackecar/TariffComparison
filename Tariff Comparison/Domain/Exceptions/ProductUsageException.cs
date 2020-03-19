using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Exceptions
{
    public class ProductUsageException : Exception
    {
        public ProductUsageException()
        {
        }

        public ProductUsageException(string message) : base(message)
        {
        }

        public ProductUsageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductUsageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
