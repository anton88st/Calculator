using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        DataHelp mydatahelp = new DataHelp();
        public MathOperations Select { get; set; } 
        public double Save { get; set; }
        public void Start()
        {
            bool endApp = true;
            while (endApp == true)
            {
                endApp = Calculate();
            }
            Console.ReadLine();
        }
        private bool Calculate()
        {
            string select = mydatahelp.OutputMenu();
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
                try
                {
                    Console.Clear();
                    mydatahelp.EnterNameApplication();
                    Select = SelectOperation(select);
                    InputNumber1();
                    InputNumber2();
                    Select.Calculate();
                    Save = Select.Result;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadLine();
                return true ;
            }
            else
            {
                return true;
            }
        }
        public MathOperations SelectOperation(string select)
        {
            MathOperations selectoperation = null; 
            switch (select)
            {
                case "a":
                    selectoperation = new Addition(); 
                    break;
                case "s":
                    selectoperation = new Subtraction(); 
                    break;
                case "m":
                    selectoperation = new Multiplication(); 
                    break;
                case "d":
                    selectoperation = new Division(); 
                    break;
                default:
                    break;
            }
            return selectoperation;
        }
        public void InputNumber1()
        {
            double Num1 = mydatahelp.InputNumber("First", Save);
            Select.Number1 = Num1;
        }
        public void InputNumber2()
        {
            double Num2 = mydatahelp.InputNumber("Second", Save);
            Select.Number2 = Num2;
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
