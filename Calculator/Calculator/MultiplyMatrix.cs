using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

namespace Calculator
{
    class MultiplyMatrix : Matrix
    {
        public override int[,] Calculation()
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
                return MatrixC; ;
        }
    }
}
