using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DataHelper mydata = new DataHelper();
            double number1 = mydata.Input("First");
            double number2 = mydata.Input("Second");
            Console.WriteLine("Select calculation: ");
            string select = Console.ReadLine();
            switch (select)
            {
                case "a":
                    Add addition = new Add { Number1 = 1, Number2 = 2 };
                    addition.Calculation();
                    break;
                case "s":
                    Subtract subtraction = new Subtract { Number1 = 1, Number2 = 2 };
                    subtraction.Calculation();
                    break;
                case "m":
                    Multiply multiplication = new Multiply { Number1 = 1, Number2 = 2 };
                    multiplication.Calculation();
                    break;
                case "d":
                    Divide division = new Divide { Number1 = 1, Number2 = 2 };
                    division.Calculation();
                    break;
            }
            Console.ReadLine();
            return;
        }
    }
    abstract class Base
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }
        public double Result { get; set; }
        public abstract void Calculation();
    }
    class Add : Base
    {
        public override void Calculation()
        {
            Result = Number1 + Number2;
            Console.WriteLine("Result:{0}", Result);
        }
    }
    class Subtract : Base
    {
        public override void Calculation()
        {
            Result = Number1 - Number2;
            Console.WriteLine("Result:{0} ", Result);
        }
    }
    class Multiply : Base
    {
        public override void Calculation()
        {
            Result = Number1 * Number2;
            Console.WriteLine("Result:{0} ", Result);
        }
    }
    class Divide : Base
    {
        public override void Calculation()
        {
            if (Number2 == 0)
            {
                throw new Exception("Number2 can't be zero");
            }
            else
            {
                Result = Number1 / Number2;
                Console.WriteLine("Result:{0} ", Result);
            }
        }
    }
}
