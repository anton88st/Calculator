using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class DataHelper
    {
        public string OutputMenu()
        {
            Console.Clear();
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
        public double InputNumbers(string name)
        {
            double Number = 0;
            Console.WriteLine("Type a {0} number: ", name);
            string inputNumber = Console.ReadLine();
                try
                {
                    while (!double.TryParse(inputNumber, out Number))
                    {
                        if (inputNumber == "q")
                        {
                            throw new Exception("Returning to the Main Menu...");
                        }
                        Console.WriteLine("An error: The entered data is not valid!! Press enter and type a valid number.");
                        Console.Write("Type a {0} number: ", name);
                        inputNumber = Console.ReadLine();
                    }
                    return Number;
                }
                catch
                {
                    throw;
                }
        }
        public void NameApplication()
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
        }
    }
}
