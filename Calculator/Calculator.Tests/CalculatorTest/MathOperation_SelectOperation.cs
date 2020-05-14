using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests.CalculatorTest
{
    public class MathOperation_SelectOperation
    {
        Calculator myCalc;
        public MathOperation_SelectOperation()
        {
            myCalc = new Calculator();
        }
        [Theory]
        [InlineData("s")]
        [InlineData("m")]
        [InlineData("a")]
        [InlineData("d")]
        public void SelectOperation_String_NotNull(string value)
        {
            Assert.NotNull(myCalc.SelectOperation(value));
        }
        [Fact]
        public void SelectOpearion_Null_Null()
        {
            Assert.Null(myCalc.SelectOperation(null));
        }
    }
}
