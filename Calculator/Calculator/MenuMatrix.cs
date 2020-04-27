using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

namespace Calculator
{
    class MenuMatrix
    {
        public void MatrixMain()
        {
            DataHelper mydata = new DataHelper();
            Console.Clear();
            mydata.NameApplication();
            int[,] matrixA = mydata.TypeMatrix("A");
            int[,] matrixB = mydata.TypeMatrix("B");

            if (matrixA.GetUpperBound(1) + 1 != matrixB.GetUpperBound(0) + 1)
                {
                    Console.WriteLine("Error: Matrix cannot be multiply. Matrix A columns not equals Matrix B rows.");
                    Console.ReadLine();
                    return;
                }

           int[,] matrixElementsA = mydata.TypeElements(matrixA, "Matrix A");
           int[,] matrixElementsB = mydata.TypeElements(matrixB, "Matrix B");

            Console.WriteLine("Matrix A");
            mydata.PrintConsole(matrixElementsA);
            Console.WriteLine("Matrix B");
            mydata.PrintConsole(matrixElementsB);

            MultiplyMatrix mymultiply = new MultiplyMatrix { MatrixA = matrixA, MatrixB = matrixB };
            Console.WriteLine("Matrix C");
            mydata.PrintConsole(mymultiply.Calculation());
            Console.ReadLine();
  
            return;
        }
    }
}
