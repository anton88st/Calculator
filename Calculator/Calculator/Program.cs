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
            NameApplication("");
            Console.WriteLine("Choose a mathematic operation:");
            Console.WriteLine("1) Addition numbers");
            Console.WriteLine("2) Substraction numbers");
            Console.WriteLine("3) Division numbers");
            Console.WriteLine("4) Multiplication numbers");
            Console.WriteLine("5) Multiplication matrices");
            Console.WriteLine("q - Exit");
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
            if (result == "5")
            {
                MatrixMain();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static double TypeNumbers(string name)
        {
            {
                string typeNumber = "";
                double dbltypeNumber = 0;

                Console.Write("{0} number: ", name);
                typeNumber = Console.ReadLine();

                while (!double.TryParse(typeNumber, out dbltypeNumber))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("{0} number: ", name);
                    typeNumber = Console.ReadLine();
                }
                return dbltypeNumber;
            }
        }
        private static void AdditionNumbers()
        {
            bool endApp = false;
            NameApplication("Addition numbers");

            while (!endApp)
            {
                double typenumber1 = TypeNumbers("First");
                double typenumber2 = TypeNumbers("Second");

                Console.WriteLine("Result: {0}+{1}={2}", typenumber1, typenumber2, typenumber1 + typenumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        private static void SubtractionNumbers()
        {
            bool endApp = false;
            NameApplication("Subtraction numbers");

            while (!endApp)
            {
                double typenumber1 = TypeNumbers("First");
                double typenumber2 = TypeNumbers("Second");

                Console.WriteLine("Result: {0}-{1}={2} ", typenumber1, typenumber2, typenumber1 - typenumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        private static void DivisionNumbers()
        {
            bool endApp = false;
            string secondNumber = "";
            double dblSecondNumber = 0;
            NameApplication("Division numbers");

            while (!endApp)
            {
                double typenumber1 = TypeNumbers("First");

                Console.Write("Second number: ");
                secondNumber = Console.ReadLine();

                while (!double.TryParse(secondNumber, out dblSecondNumber) | secondNumber == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    secondNumber = Console.ReadLine();
                }
                try
                {
                    Console.WriteLine("Result: {0}/{1}={2}", typenumber1, dblSecondNumber, typenumber1 / dblSecondNumber);
                }
                catch
                {
                    Console.WriteLine("The operation result in a mathematical error.\n");
                }
                finally
                {
                    Console.WriteLine("----------------------------------\n");
                }
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        private static void MultiplicationNumbers()
        {
            bool endApp = false;
            NameApplication("Multiplication numbers");

            while (!endApp)
            {
                double typenumber1 = TypeNumbers("First");
                double typenumber2 = TypeNumbers("Second");

                Console.WriteLine("Result: {0}x{1}={2}", typenumber1, typenumber2, typenumber1 * typenumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        private static void NameApplication(string nameOperation)
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
            Console.SetCursorPosition((Console.WindowWidth - nameOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameOperation);
            Console.WriteLine("HELP: To input a fractional number use \",\" instead of \".\"");
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
        private static void MatrixMain()
        {
            NameApplication("Multiplication matrices");

            bool endApp = false;

            while (!endApp)
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
                Console.WriteLine("----------------------------------\n");

                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        static int[,] MultiplyMatrix(int[,] MatrixA, int[,] MatrixB)
        {
            if (MatrixA.GetUpperBound(1) + 1 != MatrixB.GetUpperBound(0) + 1)
            {
                Console.WriteLine("Error: Matrix cannot be multiply. MatrixC = MatrixA. Press Enter to continue: ");
                Console.ReadLine();
                return MatrixA;
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
            bool endMethod = false;
            Console.Write("Type number of rows in matrix {0}: ", name);
            string rowsMatrix = Console.ReadLine();

            while (!int.TryParse(rowsMatrix, out cleanrowsMatrix) | rowsMatrix == "0")
            {
                Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                Console.ReadLine();
                Console.Write("Type number of rows in matrix {0}: ", name);
                rowsMatrix = Console.ReadLine();
            }

            Console.Write("Type number of columns in matrix {0}: ", name);
            string colMatrix = Console.ReadLine();

            while (!int.TryParse(colMatrix, out cleancolMatrix) | colMatrix == "0")
            {
                Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                Console.ReadLine();
                Console.Write("Type number of rows in matrix {0}: ", name);
                colMatrix = Console.ReadLine();
            }

            int[,] Matrix = new int[cleanrowsMatrix, cleancolMatrix];

            while (!endMethod)
            {
                try
                {
                    for (i = 0; i < cleanrowsMatrix; i++)
                    {
                        for (j = 0; j < cleancolMatrix; j++)
                        {
                            Console.Write("Matrix number -  [{0},{1}]: ", i, j);
                            Matrix[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Input elements is not valid. All elements in matrix will change by zero");

                }
                endMethod = true;
            }
            return Matrix;
        }
    }
}
