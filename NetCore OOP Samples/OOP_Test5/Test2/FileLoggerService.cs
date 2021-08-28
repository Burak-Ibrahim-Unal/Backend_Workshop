using System;

namespace Test2
{
    class FileLoggerService : ILoggerService
    {   
        public void Log()
        {
            Console.WriteLine("It's logged to file");
        }
    }
}
