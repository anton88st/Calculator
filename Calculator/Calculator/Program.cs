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
            if (result == "q")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Error: Input data is not valid. Press Enter and select option from list above");
                Console.ReadLine();
                return true;
            }
        }
        private static void AdditionNumbers()
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2;
            NameApplication("Addition numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return; }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q")
                { return; }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return; }
                }
                Console.WriteLine("Result: {0}+{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 + dbltypeNumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        private static void SubtractionNumbers()
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2;
            NameApplication("Subtraction numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return; }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q")
                { return; }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return; }
                }
                Console.WriteLine("Result: {0}-{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 - dbltypeNumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return;
        }
        private static void DivisionNumbers()
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2;
            NameApplication("Division numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return; }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q")
                { return; }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2) | typeNumber2 == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return; }
                }
                try
                {
                    Console.WriteLine("Result: {0}/{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 / dbltypeNumber2);
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
            double dbltypeNumber1; double dbltypeNumber2;
            NameApplication("Multiplication numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return; }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q")
                { return; }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return; }
                }
                Console.WriteLine("Result: {0}x{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 * dbltypeNumber2);
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
            Console.WriteLine("HELP: Exit from current menu - \"q\".");
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
