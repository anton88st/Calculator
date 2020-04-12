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
            bool endApp = false;
            string firstNumber = "";
            string secondNumber = "";
            double result = 0;
            double dblFirstNumber = 0;
            double dblSecondNumber = 0;

            Console.Clear();
            NameApplication();

            while (!endApp)
            {
                Console.Write("Type the first number: ");
                firstNumber = Console.ReadLine();

                while (!double.TryParse(firstNumber, out dblFirstNumber))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the first number: ");
                    firstNumber = Console.ReadLine();
                }

                Console.Write("Type the second number: ");
                secondNumber = Console.ReadLine();

                while (!double.TryParse(secondNumber, out dblSecondNumber) | secondNumber == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the second number: ");
                    secondNumber = Console.ReadLine();
                }

                result = dblFirstNumber + dblSecondNumber;

                Console.WriteLine("Result:" + dblFirstNumber + "+" + dblSecondNumber + "=" +result);
                Console.WriteLine("----------------------------------\n");

                Console.Write("Press 'Q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "Q") endApp = true;
            }
            return;
         }
         private static void SubtractionNumbers()
         {
            bool endApp = false;
            string firstNumber = "";
            string secondNumber = "";
            double result = 0;
            double dblFirstNumber = 0;
            double dblSecondNumber = 0;

            Console.Clear();
            NameApplication();

            while (!endApp)
            {
                Console.Write("Type the first number: ");
                firstNumber = Console.ReadLine();

                while (!double.TryParse(firstNumber, out dblFirstNumber))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the first number: ");
                    firstNumber = Console.ReadLine();
                }

                Console.Write("Type the second number: ");
                secondNumber = Console.ReadLine();

                while (!double.TryParse(secondNumber, out dblSecondNumber) | secondNumber == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the second number: ");
                    secondNumber = Console.ReadLine();
                }

                result = dblFirstNumber - dblSecondNumber;

                Console.WriteLine("Result: " + dblFirstNumber + "-" + dblSecondNumber + "=" + result);
                Console.WriteLine("----------------------------------\n");

                Console.Write("Press 'Q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "Q") endApp = true;
            }
            return;
         }
        private static void DivisionNumbers()
        {
            bool endApp = false;
            string firstNumber = "";
            string secondNumber = "";
            double result = 0;
            double dblFirstNumber = 0;
            double dblSecondNumber = 0;
           
            Console.Clear();
            NameApplication();

            while (!endApp)
            {
                Console.Write("Type the first number: ");
                firstNumber = Console.ReadLine();

                while (!double.TryParse(firstNumber, out dblFirstNumber))
                 {
                     Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                     Console.ReadLine();
                     Console.Write("Type the first number: ");
                     firstNumber = Console.ReadLine();
                 }
              
                Console.Write("Type the second number: ");
                secondNumber = Console.ReadLine();

                while (!double.TryParse(secondNumber, out dblSecondNumber) | secondNumber == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the second number: ");
                    secondNumber = Console.ReadLine();
                }

                result = dblFirstNumber / dblSecondNumber;
                              
                Console.WriteLine("Result:" + dblFirstNumber + "/" + dblSecondNumber + "=" + result);
                Console.WriteLine("----------------------------------\n");

                Console.Write("Press 'Q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "Q") endApp = true;
            }
            return;
        }
        private static void MultiplicationNumbers()
        {
            bool endApp = false;
            string firstNumber = "";
            string secondNumber = "";
            double result = 0;
            double dblFirstNumber = 0;
            double dblSecondNumber = 0;

            Console.Clear();
            NameApplication();

            while (!endApp)
            {
                Console.Write("Type the first number: ");
                firstNumber = Console.ReadLine();

                while (!double.TryParse(firstNumber, out dblFirstNumber))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the first number: ");
                    firstNumber = Console.ReadLine();
                }

                Console.Write("Type the second number: ");
                secondNumber = Console.ReadLine();

                while (!double.TryParse(secondNumber, out dblSecondNumber) | secondNumber == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Type the second number: ");
                    secondNumber = Console.ReadLine();
                }

                result = dblFirstNumber * dblSecondNumber;

                Console.WriteLine("Result:" + dblFirstNumber + "*" + dblSecondNumber + "=" +result);
                Console.WriteLine("----------------------------------\n");

                Console.Write("Press 'Q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "Q") endApp = true;
            }
            return;
        }
        private static void NameApplication()
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);

            
        }
        
    }
}
