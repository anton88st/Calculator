using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Calculator.Properties;

namespace Calculator
{
    class Calculate
    {
        public bool MainMenu()
        {
            bool menu = true;
            DataHelper myhelp = new DataHelper();
            string select = myhelp.OutputMenu();
            if (select == "q")
            {
                Console.WriteLine("Closing application...");
                return false;
            }
            if (select == "mm")
            {
                try
                {
                    MenuMatrix multiplyMatrix = new MenuMatrix();
                    multiplyMatrix.MatrixMain();
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
                
            }
            if (select == "a" || select == "m" || select == "s" || select == "d")
            {
                Console.Clear();
                myhelp.NameApplication();
                try
                {
                    double number1 = myhelp.InputNumbers("First");
                    double number2 = myhelp.InputNumbers("Second");
                    menu = SelectCalculate(select, number1, number2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
                return menu;
            }
            else
            {
                
                return true;
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
                default:
                    return true;
            }
        }
    }
}
