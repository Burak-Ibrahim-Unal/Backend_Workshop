using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Concrete
{
    public class Logger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Logged");
        }
    }
}
