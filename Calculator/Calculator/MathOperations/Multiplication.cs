using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Multiplication : MathOperations
    {
        public override void Calculate()
        {
            Result = Number1 * Number2;
            Console.WriteLine($"Result:{Number1}x{Number2}={Result}");
        }
    }
}
