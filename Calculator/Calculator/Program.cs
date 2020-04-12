using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMemu = true;
            while (displayMemu)
            {
                displayMemu = MainMenu();
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
                DivisionNumbers();
                return true;
            }
            if (result == "4")
            {
                MultiplicationNumbers();
                return true;
            }
            else
            {
                return false;
            }
        }
        private static void AdditionNumbers()
        {
            Console.Clear();
            Console.Write("Input first number: ");
            double firstNumber = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber + secondNumber;

            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static void SubtractionNumbers()
        {
            Console.Clear();
            Console.Write("Input first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber - secondNumber;

            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static void DivisionNumbers()
        {
            Console.Clear();
            Console.Write("Input first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber / secondNumber;

            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        private static void MultiplicationNumbers()
        {
            Console.Clear();
            Console.Write("Input first number: ");
            double firstNumber = double.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            double secondNumber = double.Parse(Console.ReadLine());

            double result = firstNumber * secondNumber;

            Console.Write("Result: ");
            Console.WriteLine(result);
            Console.ReadLine();
        }
        
    }
}
