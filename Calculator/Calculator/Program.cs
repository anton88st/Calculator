using System;

namespace Calculator
{
    class Program
    {
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
