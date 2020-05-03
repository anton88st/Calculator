using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        public bool MainMenu()
        {
            bool menu = true;
            DataHelp myhelp = new DataHelp();
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
                    multiplyMatrix.OutputMatrixMain();
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
                    Addition myaddition = new Addition { Number1 = number1, Number2 = number2 };
                    myaddition.Calculate();
                    return true;
                case "s":
                    Subtraction mysubtraction = new Subtraction { Number1 = number1, Number2 = number2 };
                    mysubtraction.Calculate();
                    return true;
                case "m":
                    Multiplication mymultiplication = new Multiplication { Number1 = number1, Number2 = number2 };
                    mymultiplication.Calculate();
                    return true;
                case "d":
                    Division mydivision = new Division { Number1 = number1, Number2 = number2 };
                    mydivision.Calculate();
                    return true;
                default:
                    return true;
            }
        }
    }
}
