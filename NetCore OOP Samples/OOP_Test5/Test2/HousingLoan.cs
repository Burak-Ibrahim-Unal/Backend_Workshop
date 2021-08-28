using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class HousingLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Housing loan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
