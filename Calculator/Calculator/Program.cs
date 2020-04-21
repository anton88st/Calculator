using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMemu = true;
            while (displayMemu)
            {
                Console.Clear();
                NameApplication("");
                Console.WriteLine("Type the first number:");
                string firstNumber = Console.ReadLine();
                if (firstNumber == "q")
                {
                    displayMemu = false;
                }
                else
                {
                    Console.WriteLine("Type the second  number");
                    string secondNumber = Console.ReadLine();
                    if (secondNumber == "q")
                    {
                        displayMemu = false;
                    }
                    else
                    {
                        Calculation myCalc = new Calculation { num1 = double.Parse(firstNumber), num2 = double.Parse(secondNumber) };
                        myCalc.Result();
                        displayMemu = true;
                    }
                }

            }
        }
        private static void NameApplication(string nameOperation)
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
        }
    }
    class Calculation
    {
        public double num1;
        public double num2;
        public double Addition()
        {
            return num1 + num2;
        }
        public double Division()
        {
            return num1 / num2;
        }
        public double Subtraction()
        {
            return num1 - num2;
        }
        public double Multiplication()
        {
            return num1 * num2;
        }
        public void Result()
        {
            Console.WriteLine("Select a mathematic operation:");
            Console.WriteLine("1) Addition numbers");
            Console.WriteLine("2) Substraction numbers");
            Console.WriteLine("3) Division numbers");
            Console.WriteLine("4) Multiplication numbers");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.WriteLine("Result:{0}+{1}={2}", num1, num2, Addition());
                    break;
                case "2":
                    Console.WriteLine("Result:{0}-{1}={2}", num1, num2, Subtraction());
                    break;
                case "3":
                    Console.WriteLine("Result:{0}/{1}={2}", num1, num2, Division());
                    break;
                case "4":
                    Console.WriteLine("Result:{0}*{1}={2}", num1, num2, Multiplication());
                    break;
                default:
                    Console.WriteLine("Error: Input data is not valid. Press Enter and select option from list above");
                    Console.ReadLine();
                    break;
            }
            Console.ReadLine();
        }
    }
}
