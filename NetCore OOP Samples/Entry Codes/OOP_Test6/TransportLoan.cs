using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class TransportLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Transport loan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
