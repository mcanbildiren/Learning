using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ILoanBaseManager personalFinanceLoanManager = new PersonalFinanceLoanManager();            
            ILoanBaseManager transportLoanManager = new TransportLoanManager();            
            ILoanBaseManager mortgageLoanManager = new MortgageLoanManager();

            IloggerService databaseLoggerService = new DatabaseLoggerService();
            IloggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(personalFinanceLoanManager, databaseLoggerService);

            List<ILoanBaseManager> loans = new List<ILoanBaseManager>() {personalFinanceLoanManager,transportLoanManager };

            //applicationManager.KrediOnBilgilendirmesiYap(loans);

        }
    }
}
