using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ApplicationCore.Exceptions
{
    public class ProductAServiceException : Exception
    {
        public ProductAServiceException()
        {
        }

        public ProductAServiceException(string message) : base(message)
        {
        }

        public ProductAServiceException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductAServiceException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
