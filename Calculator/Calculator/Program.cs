using System;

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
