using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Calculator
    {
        DataHelp myhelp = new DataHelp();
        public static double Save { get; set; }
        public void Start()
        {
            bool endApp = true;
            while (endApp == true)
            {
                endApp = SelectMainMenu();
            }
            Console.ReadLine();
        }
        private static bool Menu { get; set; }
        private bool SelectMainMenu()
        {
            string select = myhelp.OutputMenu();
            if (select == "q")
            {
                return Close();
            }
            if (select == "mm")
            {
                return EnterMenuMatrix();
            }
            if (select == "a" || select == "m" || select == "s" || select == "d")
            {
                return Menu = Calculate(select);
            }
            else
            {
                return true;
            }

        }
        private bool SelectCalculation(string select, double number1, double number2)
        {
            switch (select)
            {
                case "a":
                    Addition myaddition = new Addition { Number1 = number1, Number2 = number2 };
                    Save = myaddition.Calculate();
                    return true;
                case "s":
                    Subtraction mysubtraction = new Subtraction { Number1 = number1, Number2 = number2 };
                    Save = mysubtraction.Calculate();
                    return true;
                case "m":
                    Multiplication mymultiplication = new Multiplication { Number1 = number1, Number2 = number2 };
                    Save = mymultiplication.Calculate();
                    return true;
                case "d":
                    Division mydivision = new Division { Number1 = number1, Number2 = number2 };
                    Save = mydivision.Calculate();
                    return true;
                default:
                    return true;
            }
        }
        private bool Calculate(string select)
        {
            Console.Clear();
            myhelp.EnterNameApplication();
            try
            {
                double number1 = myhelp.InputNumbers("First", Save);
                double number2 = myhelp.InputNumbers("Second", Save);
                Menu = SelectCalculation(select, number1, number2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                return true;
            }
            Console.ReadLine();
            return Menu;
        }
        private bool EnterMenuMatrix()
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
            return true;
        }
        private bool Close()
        {
            Console.WriteLine("Closing application...");
            return false;
        }
    }
}
