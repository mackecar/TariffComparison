using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationCore.Exceptions
{
    public class ProductBServiceException : Exception
    {
        public ProductBServiceException()
        {
        }

        public ProductBServiceException(string message) : base(message)
        {
        }

        public ProductBServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductBServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
