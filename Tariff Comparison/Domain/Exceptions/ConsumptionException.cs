using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Domain.Exceptions
{
    public class ConsumptionException : Exception
    {
        public ConsumptionException()
        {
        }

        public ConsumptionException(string message) : base(message)
        {
        }

        public ConsumptionException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ConsumptionException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
