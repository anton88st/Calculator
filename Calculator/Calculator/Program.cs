using System;

namespace Matrix
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
            string nameMathOperation = "Addition numbers";
            Console.SetCursorPosition((Console.WindowWidth - nameMathOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameMathOperation);

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

                Console.WriteLine("Result:" + dblFirstNumber + "+" + dblSecondNumber + "=" + result);
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
            string nameMathOperation = "Subtraction numbers";
            Console.SetCursorPosition((Console.WindowWidth - nameMathOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameMathOperation);

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
            string nameMathOperation = "Division numbers";
            Console.SetCursorPosition((Console.WindowWidth - nameMathOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameMathOperation);

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
            string nameMathOperation = "Multiplication numbers";
            Console.SetCursorPosition((Console.WindowWidth - nameMathOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameMathOperation);

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

                Console.WriteLine("Result:" + dblFirstNumber + "*" + dblSecondNumber + "=" + result);
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

        public static void PrintConsole(int[,] Matrix)
        {
            for (int i = 0; i < Matrix.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < Matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write($"{Matrix[i, j]} \t");
                }
                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            int[,] a = GetMatrix("A");
            int[,] b = GetMatrix("B");

            Console.WriteLine("Matrix A");
            PrintConsole(a);
            Console.WriteLine("Matrix B");
            PrintConsole(b);

            int[,] result = MultiplyMatrix(a, b);
            Console.WriteLine("Matrix C");
            PrintConsole(result);

            Console.ReadLine();
        }

        static int[,] MultiplyMatrix(int[,] MatrixA, int[,] MatrixB)
        {
            if (MatrixA.GetUpperBound(1) + 1 != MatrixB.GetUpperBound(0) + 1)
            {
                Console.WriteLine("Error: Matrix cannot be multiply.");
                Console.ReadLine();
            }
            int[,] MatrixC = new int[MatrixA.GetUpperBound(0) + 1, MatrixB.GetUpperBound(1) + 1];
            for (int i = 0; i < MatrixA.GetUpperBound(0) + 1; i++)
            {
                for (int j = 0; j < MatrixB.GetUpperBound(1) + 1; j++)
                {
                    for (int k = 0; k < MatrixA.GetUpperBound(1) + 1; k++)
                    {
                        MatrixC[i, j] += MatrixA[i, k] * MatrixB[k, j];
                    }
                }
            }
            return MatrixC;
        }

        public static int[,] GetMatrix(string name)
        {
            int cleanrowsMatrix;
            int cleancolMatrix;
            int i, j;

            Console.Write("Type numbers of rows in matrix {0}: ", name);
            string rowsMatrix = Console.ReadLine();

            while (!int.TryParse(rowsMatrix, out cleanrowsMatrix) | rowsMatrix == "0")
            {
                Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                Console.ReadLine();
                Console.Write("Type numbers of rows in matrix {0}: ", name);
                rowsMatrix = Console.ReadLine();
            }

            Console.Write("Type numbers of columns in matrix {0}: ", name);
            string colMatrix = Console.ReadLine();

            while (!int.TryParse(colMatrix, out cleancolMatrix) | colMatrix == "0")
            {
                Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                Console.ReadLine();
                Console.Write("Type numbers of rows in matrix {0}: ", name);
                colMatrix = Console.ReadLine();
            }

            int[,] Matrix = new int[cleanrowsMatrix, cleancolMatrix];

            for (i = 0; i < cleanrowsMatrix; i++)
            {
                for (j = 0; j < cleancolMatrix; j++)
                {
                    Console.Write("Matrix number -  [{0},{1}]: ", i, j);
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return Matrix;
        }
    }
}
