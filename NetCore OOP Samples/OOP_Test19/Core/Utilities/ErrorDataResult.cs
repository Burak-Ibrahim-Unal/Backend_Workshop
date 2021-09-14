﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, bool success, string message) : base(data, success, message)
        {

        }

        public ErrorDataResult(T data, bool success) : base(data, success)
        {

        }

        public ErrorDataResult(string message) : base(default, false, message)
        {

        }

        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
