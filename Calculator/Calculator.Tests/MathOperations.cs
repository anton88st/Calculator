using System;
using Xunit;

namespace Calculator.Tests
{
    public class MathOperations
    {
        [Theory]
        [InlineData(-1.5)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void Add_Numbers_Result(int value)
        {
            Addition add = new Addition { Number1 = value, Number2 = value };
            add.Calculate();
            Assert.Equal(value + value, add.Result);
        }
        [Theory]
        [InlineData(-1.5)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void Subtract_Numbers_Result(int value)
        {
            Subtraction subtract = new Subtraction { Number1 = value, Number2 = value };
            subtract.Calculate();
            Assert.Equal(value - value, subtract.Result);
        }
        [Theory]
        [InlineData(-1.5)]
        [InlineData(0)]
        [InlineData(1.5)]
        public void Multiply_Numbers_Result(int value)
        {
            Multiplication multiply = new Multiplication { Number1 = value, Number2 = value };
            multiply.Calculate();
            Assert.Equal(value * value, multiply.Result);
        }
        [Theory]
        [InlineData(-1.5)]
        [InlineData(1.5)]
        public void Divide_Numbers_Result(int value)
        {
            Division divide = new Division { Number1 = value, Number2 = value };
            divide.Calculate();
            Assert.Equal(value / value, divide.Result);
        }
        [Fact]
        public void DivisionByZero()
        {
            int value = 0;
            Division divide = new Division { Number1 = value, Number2 = value };
            Assert.Throws<DivideByZeroException>(() => divide.Calculate());
        }
    }
}
