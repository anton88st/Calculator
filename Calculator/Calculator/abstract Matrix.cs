using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

namespace Calculator
{
    abstract class Matrix
    {
        public int[,] MatrixA { get; set; }
        public int[,] MatrixB { get; set; }
        abstract public int[,] Calculation();
    }
}
