using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class DataHelp
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
            double Number;
            Console.Write("Type a {0} number: ", name);
            string inputNumber = Console.ReadLine();

            while (!double.TryParse(inputNumber, out Number))
            {
                if (inputNumber == "q")
                {
                    throw new Exception("Returning to the Main Menu...");
                }
                if (inputNumber == "s")
                {
                    return Number;
                }
                Console.WriteLine("The entered data is not valid!! Type only numbers.");
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
        public int[,] TypeParametersMatrix(string name)
        {
            int cleanrowsMatrix; int cleancolsMatrix;
            Console.Write("Type number of rows in matrix {0}: ", name);
            string rowsMatrix = Console.ReadLine();
            while (!Int32.TryParse(rowsMatrix, out cleanrowsMatrix) || cleanrowsMatrix <= 0)
            {
                if (rowsMatrix == "q")
                {
                    throw new Exception("Returning to the Main Menu...");
                }
                Console.WriteLine("Entered data isn't valid. Type only positive integer numbers.");
                Console.Write("Type number of rows in matrix {0}: ", name);
                rowsMatrix = Console.ReadLine();
            }
            Console.Write("Type number of columns in matrix {0}: ", name);
            string colsMatrix = Console.ReadLine();
            while (!Int32.TryParse(colsMatrix, out cleancolsMatrix) || cleancolsMatrix <= 0)
            {
                if (colsMatrix == "q")
                {
                    throw new Exception("Returning to the Main Menu...");
                }
                Console.WriteLine("Entered data isn't valid. Type only positive integer numbers.");
                Console.Write("Type number of columns in matrix {0}: ", name);
                colsMatrix = Console.ReadLine();
            }
            int[,] Matrix = new int[cleanrowsMatrix, cleancolsMatrix];
            return Matrix;
        }
        public int[,] TypeElementsMatrix(int[,] matrix, string name)
        {
            int i; int j; int cleanelement;
            for (i = 0; i < matrix.GetUpperBound(0) + 1; i++)
            {
                for (j = 0; j < matrix.GetUpperBound(1) + 1; j++)
                {
                    Console.Write("{0} number -  [{1},{2}]: ", name, i, j);
                    string element = Console.ReadLine();
                    while (!Int32.TryParse(element, out cleanelement))
                    {
                        if (element == "q")
                        {
                            throw new Exception("Returning to the Main Menu...");
                        }
                        Console.WriteLine("Entered data isn't valid. Type only integer numbers.");
                        Console.Write("{0} number -  [{1},{2}]: ", name, i, j);
                        element = Console.ReadLine();
                    }
                    matrix[i, j] = cleanelement;
                }
            }
            return matrix;
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
