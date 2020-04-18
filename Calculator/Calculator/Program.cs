using System;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            string saveInMemory = "0";
            bool displayMemu = true;
            while (displayMemu)
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
                switch (result)
                {
                    case "1":
                        saveInMemory = AdditionNumbers(saveInMemory);
                        displayMemu = true;
                            break;
                    case "2":
                        saveInMemory = SubtractionNumbers(saveInMemory);
                        displayMemu = true;
                        break;
                    case "3":
                        saveInMemory = DivisionNumbers(saveInMemory);
                        displayMemu = true;
                        break;
                    case "4":
                        saveInMemory = MultiplicationNumbers(saveInMemory);
                        displayMemu = true;
                        break;
                    case "5":
                        MatrixMain();
                        displayMemu = true;
                        break;
                    case "q":
                        displayMemu = false;
                        break;
                    default:
                        Console.WriteLine("Error: Input data is not valid. Press Enter and select option from list above");
                        Console.ReadLine();
                        displayMemu = true;
                        break;
                }
            }
        }
        private static string AdditionNumbers(string saveInMemory)
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2; double result = 0;
            NameApplication("Addition numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return saveInMemory; }
                if (typeNumber1 == "s") { typeNumber1 = saveInMemory;}
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q") { return saveInMemory; }
                if (typeNumber2 == "s")
                {
                    typeNumber2 = saveInMemory;
                }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                result = dbltypeNumber1 + dbltypeNumber2;
                saveInMemory = Convert.ToString(result);
                Console.WriteLine("Result: {0}+{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 + dbltypeNumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return saveInMemory;
        }
        private static string SubtractionNumbers(string saveInMemory)
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2; double result = 0;
            NameApplication("Subtraction numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return saveInMemory; }
                if (typeNumber1 == "s")
                {
                    typeNumber1 = saveInMemory;
                }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q") { return saveInMemory; }
                if (typeNumber2 == "s")
                {
                    typeNumber2 = saveInMemory;
                }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                result = dbltypeNumber1 - dbltypeNumber2;
                saveInMemory = Convert.ToString(result);
                Console.WriteLine("Result: {0}-{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 - dbltypeNumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return saveInMemory;
        }
        private static string DivisionNumbers(string saveInMemory)
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2; double result = 0;
            NameApplication("Division numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return saveInMemory; }
                if (typeNumber1 == "s")
                {
                    typeNumber1 = saveInMemory;
                }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q") { return saveInMemory; }
                if (typeNumber2 == "s")
                {
                    typeNumber2 = saveInMemory;
                }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2) | typeNumber2 == "0")
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                try
                {
                    result = dbltypeNumber1 / dbltypeNumber2;
                    saveInMemory = Convert.ToString(result);
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
            return saveInMemory;
        }
        private static string MultiplicationNumbers(string saveInMemory)
        {
            bool endApp = false;
            double dbltypeNumber1; double dbltypeNumber2; double result = 0;
            NameApplication("Multiplication numbers");
            while (!endApp)
            {
                Console.Write("First number: ");
                string typeNumber1 = Console.ReadLine();
                if (typeNumber1 == "q") { return saveInMemory; }
                if (typeNumber1 == "s")
                {
                    typeNumber1 = saveInMemory;
                }
                while (!double.TryParse(typeNumber1, out dbltypeNumber1))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("First number: ");
                    typeNumber1 = Console.ReadLine();
                    if (typeNumber1 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                Console.Write("Second number: ");
                string typeNumber2 = Console.ReadLine();
                if (typeNumber2 == "q") { return saveInMemory; }
                if (typeNumber2 == "s")
                {
                    typeNumber2 = saveInMemory;
                }
                while (!double.TryParse(typeNumber2, out dbltypeNumber2))
                {
                    Console.Write("An error: The entered data is not valid!! Press enter and type a valid number.");
                    Console.ReadLine();
                    Console.Write("Second number: ");
                    typeNumber2 = Console.ReadLine();
                    if (typeNumber2 == "q") { return saveInMemory; }
                    if (typeNumber1 == "s") { typeNumber1 = saveInMemory; }
                }
                result = dbltypeNumber1 * dbltypeNumber2;
                saveInMemory = Convert.ToString(result);
                Console.WriteLine("Result: {0}x{1}={2}", dbltypeNumber1, dbltypeNumber2, dbltypeNumber1 * dbltypeNumber2);
                Console.WriteLine("----------------------------------\n");
                Console.Write("Press 'q' and close the app, or press any other key and to continue: ");
                if (Console.ReadLine() == "q") endApp = true;
            }
            return saveInMemory;
        }
        private static void NameApplication(string nameOperation)
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
            Console.SetCursorPosition((Console.WindowWidth - nameOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameOperation);
            Console.WriteLine("HELP: Exit from current menu - \"q\". To input last result press \"s\".");
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
            string nameApplication = "Welcome: Console Calculator.\n";
            string nameOperation = "Multiplication Matrix.";
            Console.Clear();
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
            Console.SetCursorPosition((Console.WindowWidth - nameOperation.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameOperation);
            bool endApp = false;

            while (!endApp)
            {
                int[,] a = GetMatrix("A");
                int[,] b = GetMatrix("B");

                if (a.GetUpperBound(1) + 1 != b.GetUpperBound(0) + 1)
                {
                    Console.WriteLine("Error: Matrix cannot be multiply. Matrix A columns not equals Matrix B rows.");
                    Console.ReadLine();
                    return;
                }
                               
                int[,] aa = TypeElementsA(a);
                int[,] bb = TypeElementsB(b);

                Console.WriteLine("Matrix A");
                PrintConsole(aa);
                Console.WriteLine("Matrix B");
                PrintConsole(bb);

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
            return Matrix;
        }
        public static int[,] TypeElementsA(int[,] MatrixA)
        {
            bool endMethod = false; int i; int j;
            while (!endMethod)
            {
                try
                {
                    for (i = 0; i < MatrixA.GetUpperBound(0) + 1; i++)
                    {
                        for (j = 0; j < MatrixA.GetUpperBound(1) + 1; j++)
                        {
                            Console.Write("MatrixA number -  [{0},{1}]: ", i, j);
                            MatrixA[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Input elements is not valid. All elements in matrix will change by zero");

                }
                endMethod = true;
            }
            return MatrixA;
        }
        public static int[,] TypeElementsB(int[,] MatrixB)
        {
            bool endMethod = false; int i; int j;
           
            while (!endMethod)
            {
                try
                {
                    for (i = 0; i < MatrixB.GetUpperBound(0) + 1; i++)
                    {
                        for (j = 0; j < MatrixB.GetUpperBound(1) + 1; j++)
                        {
                            Console.Write("MatrixB number -  [{0},{1}]: ", i, j);
                            MatrixB[i, j] = int.Parse(Console.ReadLine());
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Input elements is not valid. All elements in matrix will change by zero");

                }
                endMethod = true;
            }
            return MatrixB;
        }
    }
}
