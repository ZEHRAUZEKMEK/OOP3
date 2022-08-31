using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerLoanManager = new ConsumerLoanManager();
            

            ICreditManager vehicleLoanManager = new VehicleLoanManager();
            

            ICreditManager housingLoanManager = new HousingLoanManager();

            ILoggerService DatabaseLoggerService = new DatabaseLoggerService();
            ILoggerService FileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.MakeApplication(vehicleLoanManager, DatabaseLoggerService);
            applicationManager.MakeApplication(new CraftCreditManager(), new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });

            List<ICreditManager> credits = new List<ICreditManager>() { consumerLoanManager, vehicleLoanManager};
            //applicationManager.PreBriefTheLoan(credits);
        }
    }
}
