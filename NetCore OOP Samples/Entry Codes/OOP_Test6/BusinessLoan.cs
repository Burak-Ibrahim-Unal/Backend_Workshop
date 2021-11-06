using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class BusinessLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Business loan is calculated");        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
