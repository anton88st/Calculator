using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;


namespace Calculator
{
    class DataHelper
    {
        public string OutputMenu()
        {
            Console.Clear();
            NameApplication();
            Console.WriteLine("Select calculation: ");
            Console.WriteLine("Add numbers-------- a");
            Console.WriteLine("Substract numbers-- s");
            Console.WriteLine("Divide numbers----- d");
            Console.WriteLine("Multiply numbers--- m");
            Console.WriteLine("Multiply matrics--- mm");
            Console.WriteLine("Exit--------------- q");
            Console.Write("Your choice: ");
            string select = Console.ReadLine();
            return select;
        }
        public double InputNumbers(string name)
        {
            double Number = 0;
            Console.WriteLine("Type a {0} number: ", name);
            string inputNumber = Console.ReadLine();
                    
            while (!double.TryParse(inputNumber, out Number))
                    {
                        if (inputNumber == "q")
                        {
                            throw new Exception("Returning to the Main Menu...");
                        }
                        if (inputNumber == "s")
                {
                    Number = Settings.Default.SaResult;
                    return Number;
                }
                        Console.WriteLine("An error: The entered data is not valid!! Press enter and type a valid number.");
                        Console.Write("Type a {0} number: ", name);
                        inputNumber = Console.ReadLine();
                    }
                    return Number;
        }
        public void NameApplication()
        {
            string nameApplication = "Welcome: Console Calculator.\n";
            Console.SetCursorPosition((Console.WindowWidth - nameApplication.Length) / 2, Console.CursorTop);
            Console.WriteLine(nameApplication);
        }
        public int[,] TypeMatrix(string name)
        {
            Console.Write("Type number of rows in matrix {0}: ", name);
            string rowsMatrix = Console.ReadLine();
            int cleanrowsMatrix = Convert.ToInt32(rowsMatrix);
            Console.Write("Type number of columns in matrix {0}: ", name);
            string colMatrix = Console.ReadLine();
            int cleancolMatrix = Convert.ToInt32(colMatrix);
            int[,] Matrix = new int[cleanrowsMatrix, cleancolMatrix];
            return Matrix;
        }
        public int[,] TypeElementsA(int[,] MatrixA)
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
        public int[,] TypeElementsB(int[,] MatrixB)
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
        public void PrintConsole(int[,] Matrix)
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
    }
}
