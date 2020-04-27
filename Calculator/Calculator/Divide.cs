using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

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
                Console.WriteLine("Result:{0} ", Result);
                Settings.Default.SaResult = Result;
            }
            return Result;
        }
    }
}
