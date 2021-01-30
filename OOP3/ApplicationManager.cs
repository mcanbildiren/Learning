using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ILoanBaseManager loanBaseManager, IloggerService loggerService)
        {
            loanBaseManager.Calculate();
            loggerService.Log();
        }

        public void KrediOnBilgilendirmesiYap(List<ILoanBaseManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
