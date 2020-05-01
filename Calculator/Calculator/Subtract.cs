using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Subtract : Base
    {
        public override double Calculation()
        {
            Result = Number1 - Number2;
            Console.WriteLine("Result:{0}-{1}={2}", Number1, Number2, Result);
            return Result;
        }
    }
}
