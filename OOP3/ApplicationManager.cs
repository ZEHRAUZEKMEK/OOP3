using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService> loggerServices)
        {
            creditManager.Calculate();

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
            
        }


        public void PreBriefTheLoan(List<ICreditManager> credits)
        {
            
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
