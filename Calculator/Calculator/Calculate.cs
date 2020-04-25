using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculate
    {
        public bool MainMenu()
        {
            DataHelper myhelp = new DataHelper();
            string select = myhelp.OutputMenu();
            if (select == "q")
            {
                return false;
            }
            else
            {
                Console.Clear();
                double number1 = myhelp.InputNumbers("First");
                double number2 = myhelp.InputNumbers("Second");
                bool menu = SelectCalculate(select, number1, number2);
                Console.ReadLine();
                return menu;
            }
            
        }
        public bool SelectCalculate(string select, double number1, double number2)
        {
            switch (select)
            {
                case "a":
                    Add addition = new Add { Number1 = number1, Number2 = number2 };
                    addition.Calculation();
                    return true;
                case "s":
                    Subtract subtraction = new Subtract { Number1 = number1, Number2 = number2 };
                    subtraction.Calculation();
                    return true;
                case "m":
                    Multiply multiplication = new Multiply { Number1 = number1, Number2 = number2 };
                    multiplication.Calculation();
                    return true;
                case "d":
                    Divide division = new Divide { Number1 = number1, Number2 = number2 };
                    division.Calculation();
                    return true;
                case "q":
                    return false;
                default:
                    return true;
            }
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
