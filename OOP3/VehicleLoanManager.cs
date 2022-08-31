using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class VehicleLoanManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("The vehicle credit plan has been calculated.");
        }
    }
}
