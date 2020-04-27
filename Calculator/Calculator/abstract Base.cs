using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Properties;

namespace Calculator
{
    abstract class Base
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public abstract double Calculation();
    }
}
