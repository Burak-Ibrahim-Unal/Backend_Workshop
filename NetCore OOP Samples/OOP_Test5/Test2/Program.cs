using System;
using System.Collections.Generic;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelLoan pl = new PersonelLoan();
            pl.Calculate();

            TransportLoan tl = new TransportLoan();
            tl.Calculate();

            HousingLoan hl = new HousingLoan();
            hl.Calculate();

            Console.WriteLine("-----------------------------------------");

            ILoanManager pl1 = new PersonelLoan();
            pl.Calculate();

            ILoanManager tl1 = new TransportLoan();
            tl.Calculate();

            ILoanManager hl1 = new HousingLoan();
            hl.Calculate();

            Console.WriteLine("-----------------------------------------");

            ApplicationManager am = new ApplicationManager();
            am.MakeApplication(tl);
            am.MakeApplication(hl);
            am.MakeApplication(pl);

            Console.WriteLine("-----------------------------------------");

            ApplicationManager am1 = new ApplicationManager();
            am1.MakeApplication(new PersonelLoan());
            am1.MakeApplication(new HousingLoan());
            am1.MakeApplication(new TransportLoan());

            Console.WriteLine("-----------------------------------------");

            ApplicationManager am2 = new ApplicationManager();
            ILoanManager pl2 = new PersonelLoan();
            ILoanManager tl2 = new TransportLoan();
            ILoanManager hl2 = new HousingLoan();
            List<ILoanManager> loans = new List<ILoanManager>() { pl2, tl2 };
            am2.ExamineCreditApp(loans);

            Console.WriteLine("-----------------------------------------");

            ILoggerService dbLogger = new DatabaseLoggerService();
            ILoggerService fileLogger = new FileLoggerService();
            ApplicationManager am3 = new ApplicationManager();
            am3.MakeApplication(pl1,fileLogger);

            Console.WriteLine("-----------------------------------------");
            ApplicationManager am4 = new ApplicationManager();
            am4.MakeApplication(new BusinessLoan(), dbLogger);


            Console.WriteLine("-----------------------------------------");
            ApplicationManager am5 = new ApplicationManager();
            am5.MakeApplication(new BusinessLoan(), new SmsLoggerService());

            Console.WriteLine("-----------------------------------------");
            ApplicationManager am6 = new ApplicationManager();
            am5.MakeApplication(new BusinessLoan(), new List<ILoggerService>{dbLogger,new SmsLoggerService(),fileLogger });






        }
    }
}
