using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class MenuMatrix
    {
        public void OutputMatrixMain()
        {
            DataHelp mydata = new DataHelp();
            Console.Clear();
            mydata.EnterNameApplication();
            int[,] matrixA = mydata.TypeParametersMatrix("A");
            int[,] matrixB = mydata.TypeParametersMatrix("B");

            if (matrixA.GetUpperBound(1) + 1 != matrixB.GetUpperBound(0) + 1)
            {
                throw new Exception("Columns number in Matrix A should be equal by rows number in Matrix B.");
            }

            int[,] matrixElementsA = mydata.TypeElementsMatrix(matrixA, "Matrix A");
            int[,] matrixElementsB = mydata.TypeElementsMatrix(matrixB, "Matrix B");

            Console.WriteLine("Matrix A");
            mydata.PrintConsole(matrixElementsA);
            Console.WriteLine("Matrix B");
            mydata.PrintConsole(matrixElementsB);

            MultiplicationMatrix mymultiply = new MultiplicationMatrix { MatrixA = matrixA, MatrixB = matrixB };
            Console.WriteLine("Matrix C");
            mydata.PrintConsole(mymultiply.Calculate());
            Console.ReadLine();
        }
        
    }
}
