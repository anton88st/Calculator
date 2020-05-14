using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests.CalculatorTest
{
    public class SaveTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1.5)]
        [InlineData(1.5)]
        public void Save_Numbers_Result(double value)
        {
            Calculator myCalc = Mock.Of<Calculator>(p => p.Save == value);
            double Save = myCalc.Save;
            Assert.Equal(value, Save);
        }

    }
}
