using System;
using System.Collections.Generic;
using System.Text;

namespace Test2
{
    class ApplicationManager
    {
        public void MakeApplication(ILoanManager loanManager)
        {
            loanManager.Calculate();
        }
        public void MakeApplication(ILoanManager loanManager, ILoggerService loggerService)
        {
            loanManager.Calculate();
            loggerService.Log();
        }

        public void MakeApplication(ILoanManager loanManager, List<ILoggerService> loggerService)
        {
            loanManager.Calculate();
            foreach (var logger in loggerService)
            {
                logger.Log();

            }
        }

        public void ExamineCreditApp(List<ILoanManager> loanList)
        {
            foreach (var loan in loanList)
            {
                loan.Calculate();
            }
        }
    }
}
