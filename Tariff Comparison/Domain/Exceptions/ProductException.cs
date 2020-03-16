using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Exceptions
{
    public class ProductException : Exception
    {
        public ProductException()
        {
        }

        public ProductException(string message) : base(message)
        {
        }

        public ProductException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
