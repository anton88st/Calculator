using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose the mathematic operation:");
            Console.WriteLine("1) Addition numbers");
            Console.WriteLine("2) Substraction numbers");
            Console.WriteLine("3) Division numbers");
            Console.WriteLine("4) Multiplication numbers");
            Console.WriteLine("5) Exit");
            Console.Write("Your choice: ");
            string result = Console.ReadLine();

            if (result == "1")
            {
                AdditionNumbers();
                return true;
            }

            if (result == "2")
            {
                SubtractionNumbers();
                return true;
             }
            
            if (result == "3")
            {
                Division();
                return true;
            }
            if (result == "4")
            {
                Multiplication();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
