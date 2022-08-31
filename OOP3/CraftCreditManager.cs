using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CraftCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The craft credit has been calculated.");
        }
    }
}
