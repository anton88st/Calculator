using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AdditionNumbers();
            SubtractionNumbers();
            DivisionNumbers();
            MultiplicationNumbers();
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
