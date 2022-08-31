using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ConsumerLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The consumer credit plan has been calculated.");
        }
    }
}
