using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

namespace Calculator
{
    class Add : Base
    {
        public override double Calculation()
        {
            Result = Number1 + Number2;
            Console.WriteLine("Result:{0}", Result);
            Settings.Default.SaResult = Result;
            return Result;
        }
    }
}
