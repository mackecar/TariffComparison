using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApi
{
    public static class ResponseHelper
    {
        public static object ErrorResponse(params string[] errors)
        {
            return new
            {
                Errors = errors
            };
        }
    }
}
