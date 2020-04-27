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
            int[,] a = mydata.TypeMatrix("A");
            int[,] b = mydata.TypeMatrix("B");

            if (a.GetUpperBound(1) + 1 != b.GetUpperBound(0) + 1)
                {
                    Console.WriteLine("Error: Matrix cannot be multiply. Matrix A columns not equals Matrix B rows.");
                    Console.ReadLine();
                    return;
                }

            int[,] aa = mydata.TypeElementsA(a);
            int[,] bb = mydata.TypeElementsB(b);

            Console.WriteLine("Matrix A");
            mydata.PrintConsole(aa);
            Console.WriteLine("Matrix B");
            mydata.PrintConsole(bb);

            MultiplyMatrix mymultiply = new MultiplyMatrix { MatrixA = a, MatrixB = b };
            int[,] result = mymultiply.Calculation();
            Console.WriteLine("Matrix C");
            mydata.PrintConsole(result);
            Console.ReadLine();
  
            return;
        }
    }
}
