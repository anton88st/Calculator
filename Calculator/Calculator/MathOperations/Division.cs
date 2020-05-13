using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Division : MathOperations
    {
        public override void Calculate()
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                Result = Number1 / Number2;
                Console.WriteLine($"Result:{Number1}/{Number2}={Result}");
            }
        }
    }
}
