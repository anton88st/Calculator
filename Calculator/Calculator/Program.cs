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
            Select myselect = new Select();
            bool mainMenu = myselect.MainMenu();
            while (mainMenu == true)
            {
                mainMenu = myselect.MainMenu();
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
