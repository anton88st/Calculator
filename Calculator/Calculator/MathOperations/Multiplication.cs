using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Multiplication : MathOperations
    {
        public override double Calculate()
        {
            Result = Number1 * Number2;
            Console.WriteLine("Result:{0}x{1}={2}", Number1, Number2, Result);
            return Result;
        }
    }
}
