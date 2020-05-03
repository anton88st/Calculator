using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator myselect = new Calculator();
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
