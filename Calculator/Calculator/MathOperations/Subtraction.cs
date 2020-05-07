using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Subtraction : MathOperations
    {
        public override void Calculate()
        {
            Result = Number1 - Number2;
            Console.WriteLine("Result:{0}-{1}={2}", Number1, Number2, Result);
        }
    }
}
