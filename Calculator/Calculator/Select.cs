using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Select
    {
        public bool MainMenu()
        {
            DataHelper myhelp = new DataHelper();
            string select = myhelp.InputMenu();
            if (select == "q")
            {
                return false;
            }
            else
            {
                Console.Clear();
                double number1 = myhelp.Input("First");
                double number2 = myhelp.Input("Second");
                bool menu = Selection(select, number1, number2);
                Console.ReadLine();
                return menu;
            }
            
        }
        public bool Selection(string select, double number1, double number2)
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
}
