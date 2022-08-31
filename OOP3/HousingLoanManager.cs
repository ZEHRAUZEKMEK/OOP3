using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HousingLoanManager : ICreditManager //HEsapla bunun da içinde
    {
        public void Calculate()
        {
            Console.WriteLine("The mortgage payment plan has been calculated.");
        }
    }
}
