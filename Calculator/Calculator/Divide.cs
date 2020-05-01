using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Divide : Base
    {
        public override double Calculation()
        {
            if (Number2 == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                Result = Number1 / Number2;
                Console.WriteLine("Result:{0}/{1}={2}", Number1, Number2, Result);
            }
            return Result;
        }
    }
}
