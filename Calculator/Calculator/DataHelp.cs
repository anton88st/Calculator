using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class DataHelp
    {
        public double Number { get; set; }
        public string NameApp = "Welcome: Console Calculator.\n";
        public int CleanrowsMatrix { get; set; }
        public int CleancolsMatrix { get; set; }
        public string OutputMenu()
        {
            Console.Clear();
            EnterNameApplication();
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
        public double InputNumber(string name, double Save)
        {
            bool endApp = false;
            while (!endApp)
            {
                string num = InputNumberInConsole(name);
                if (num == "q")
                {
                    CompareInputNumberByExit();
                }
                if (num == "s")
                {
                    return Number = CompareInputNumberbySaveResult(Save);
                }
                else
                {
                    try
                    {
                        return Number = ConvertInputNumber(num);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        endApp = false;
                    }
                }
            }
            return Number;
        }
        public virtual string InputNumberInConsole(string name)
        {
            Console.Write("Type a {0} number: ", name);
            string inputNumberConsole = Console.ReadLine();
            return inputNumberConsole;
        }
        public void CompareInputNumberByExit()
        {
            throw new Exception("Returning to the Main Menu...");
        }
        public double CompareInputNumberbySaveResult(double Save)
        {
            Number = Save;
            return Number;
        }
        public double ConvertInputNumber(string num)
        {
            Number = double.Parse(num);
            return Number;
        }
        public void EnterNameApplication()
        {
            Console.SetCursorPosition((Console.WindowWidth - NameApp.Length) / 2, Console.CursorTop);
            Console.WriteLine(NameApp);
        }
        public int[,] TypeParametersMatrix(string name)
        {
            ParametersMatrix(name);
            int[,] Matrix = new int[CleanrowsMatrix, CleancolsMatrix];
            return Matrix;
        }
        public void ParametersMatrix(string name)
        {
            CleanrowsMatrix = ParameterMatrix(name, "rows");
            CleancolsMatrix = ParameterMatrix(name, "columns");
        }
        public int ParameterMatrix(string name, string nameParameter)
        {
            int parameterInt = 0;
            bool endApp = false;
            while (!endApp)
            {
                string parameterMatrix = InputConsoleParameterMatrix(name, nameParameter);
                if (parameterMatrix == "q")
                {
                    CompareInputNumberByExit();
                }
                else
                {
                    try
                    {
                        parameterInt = ConvertParameterMatrix(parameterMatrix);
                        CompareParameterMatrixByLessZero(parameterInt);
                        return parameterInt; 
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        endApp = false;
                    }
                }
            }
            return parameterInt; 
        }
        public int ConvertParameterMatrix(string nameParameter)
        {
                int parameter = int.Parse(nameParameter);
                return parameter;
        }
        public void CompareParameterMatrixByLessZero(int parameterInt)
        {
            if (parameterInt <= 0)
            {
                throw new Exception("Input number can't be less than 1");
            }
        }
        public virtual string InputConsoleParameterMatrix(string nameMatrix, string nameParameter)
        {
            Console.Write("Type number of {1} in matrix {0}: ", nameMatrix, nameParameter);
            string parameterMatrix = Console.ReadLine();
            return parameterMatrix;
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
