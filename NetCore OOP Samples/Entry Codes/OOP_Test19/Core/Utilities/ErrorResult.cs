﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class ErrorResult : Result
    {
        public ErrorResult(bool success) : base(false)
        {

        }

        public ErrorResult(bool success, string message) : base(false, message)
        {

        }
    }
}
