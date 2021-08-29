using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class PersonelLoan : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Personel loan calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
