using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests.CalculatorTest
{
    public class CloseTest
    {
        [Fact]
        public void Close_FalseResult()
        {
            Calculator myCalc = new Calculator();
            Assert.False(myCalc.Close());
        }

    }
}
