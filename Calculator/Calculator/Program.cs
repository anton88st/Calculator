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
            Console.WriteLine("Select operation: ");

            string select = Console.ReadLine();
            switch (select)
            {
                case "a":
                    Addition addition = new Addition { Number1 = 1, Number2 = 2 };
                    addition.Calculation();
                    break;
                case "s":
                    Subtraction subtraction = new Subtraction { Number1 = 1, Number2 = 2 };
                    subtraction.Calculation();
                    break;
                case "m":
                    Multiplication multiplication = new Multiplication { Number1 = 1, Number2 = 2 };
                    multiplication.Calculation();
                    break;
                case "d":
                    Division division = new Division { Number1 = 1, Number2 = 2 };
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
    class Addition : Base
    {
        public override void Calculation()
        {
            Result = Number1 + Number2;
            Console.WriteLine("Result:{0}", Result);
            return;
        }
    }
    class Subtraction : Base
    {
        public override void Calculation()
        {
            Result = Number1 - Number2;
            Console.WriteLine("Result:{0} ", Result);
            return;
        }
    }
    class Multiplication : Base
    {
        public override void Calculation()
        {
            Result = Number1 * Number2;
            Console.WriteLine("Result:{0} ", Result);
            return;
        }
    }
    class Division : Base
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
            return;
        }
    }
}
