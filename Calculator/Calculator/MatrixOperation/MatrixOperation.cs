using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    abstract class MatrixOperation
    {
        public int[,] MatrixA { get; set; }
        public int[,] MatrixB { get; set; }
        abstract public int[,] Calculate();
    }
}
