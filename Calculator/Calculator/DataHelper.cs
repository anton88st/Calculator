using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DataHelper
    {
        public string InputMenu()
        {
            NameApplication();
            Console.WriteLine("Select calculation: ");
            Console.WriteLine("Add numbers-------- a");
            Console.WriteLine("Substract numbers-- s");
            Console.WriteLine("Divide numbers----- d");
            Console.WriteLine("Multiply numbers--- m");
            Console.WriteLine("Exit--------------- q");
            Console.Write("Your choice: ");
            string select = Console.ReadLine();
            return select;
        }
        public double Input(string name)
        {
            double Number = 0;
            Console.WriteLine("Type a {0} number: ", name);
            string inputNumber = Console.ReadLine();
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
        public void NameApplication()
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
        }
    }
}
