using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DataHelper
    {
        public double Input(string name)
        {
            double Number = 0;
            Console.WriteLine("Type a {0} number: ", name);
            string inputNumber = Console.ReadLine();
            if (inputNumber == "q")
            {
                throw new Exception("Moving to the Main Menu.");
            }
            try
            {
                Number = Convert.ToDouble(inputNumber);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
            return Number;
        }
    }
}
