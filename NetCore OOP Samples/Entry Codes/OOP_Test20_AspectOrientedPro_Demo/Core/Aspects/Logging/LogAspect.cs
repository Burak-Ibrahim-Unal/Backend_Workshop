using PostSharp.Aspects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging.Concrete
{
    [Serializable]
    public class LogAspect : OnMethodBoundaryAspect
    {

        public override void OnEntry(MethodExecutionArgs args)
        {
            Console.WriteLine("Logged");
        }

    }
}
