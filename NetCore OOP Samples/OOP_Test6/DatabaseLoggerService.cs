using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("It's logged to DB");
        }
    }
}
