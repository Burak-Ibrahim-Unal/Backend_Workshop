using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class Result : IResult
    {
        public bool Success { get; }

        public string Messages { get; }


        public Result(bool success, string message) : this(success) // invoke 2nd constructor automatically when this constructor is invoked
        {
            Messages = message;
        }

        public Result(bool success)
        {
            Success = success;
        }
    }
}
