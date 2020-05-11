using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        DataHelp myhelp = new DataHelp();
        public double Save { get; set; }
        public void Start()
        {
            bool endApp = true;
            while (endApp == true)
            {
                endApp = SelectMainMenu();
            }
            Console.ReadLine();
        }
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
                Calculate(select);
                return true ;
            }
            else
            {
                return true;
            }

        }
        public void MathOperations(string select)
        {
            switch (select)
            {
                case "a":
                    Add();
                    break;
                case "s":
                    Subtract();
                    break;
                case "m":
                    Multiply();
                    break;
                case "d":
                    Divide();
                    break;
                default:
                    break;
            }
        }
        public virtual void Add()
        {
            Addition myAddition = new Addition { Number1 = InputNumber1(), Number2 = InputNumber2() };
            myAddition.Calculate();
            Save = myAddition.Result;
        }
        public void Subtract()
        {
            Subtraction mysubtraction = new Subtraction { Number1 = InputNumber1(), Number2 = InputNumber2() };
            mysubtraction.Calculate();
            Save = mysubtraction.Result;
        }
        public void Multiply()
        {
            Multiplication mymultiplication = new Multiplication { Number1 = InputNumber1(), Number2 = InputNumber2() };
            mymultiplication.Calculate();
            Save = mymultiplication.Result;
        }
        public void Divide()
        {
            Division mydivision = new Division { Number1 = InputNumber1(), Number2 = InputNumber2() };
            mydivision.Calculate();
            Save = mydivision.Result;
        }
        public double InputNumber1()
        {
           double Number1 = myhelp.InputNumber("First", Save);
            return Number1;
        }
        public double InputNumber2()
        {
            double Number2 = myhelp.InputNumber("Second", Save);
            return Number2; 
        }
        private void Calculate(string select)
        {
            Console.Clear();
            myhelp.EnterNameApplication();
            try
            {
               MathOperations(select);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
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
