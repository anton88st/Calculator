using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate myselect = new Calculate();
            bool mainMenu = myselect.MainMenu();
            while (mainMenu == true)
            {
                mainMenu = myselect.MainMenu();
            }
            Console.ReadLine();
            return;
        }
    }
}
