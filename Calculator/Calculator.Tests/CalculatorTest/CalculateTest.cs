using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests.CalculatorTest
{
    public class CalculateTest
    {
        [Fact]
        public void Calculate_q_False()
        {
            var mock = new Mock<Calculator>();
            mock.Setup(obj => obj.Close()).Returns(false);
            Calculator myCalc = mock.Object;
            Assert.False(myCalc.Calculate("q"));
        }
        [Fact]
        public void Calculate_mm_True()
        {
            var mock = new Mock<Calculator>();
            mock.Setup(obj => obj.EnterMenuMatrix()).Returns(true);
            Calculator myCalc = mock.Object;
            Assert.True(myCalc.Calculate("mm"));
        }
    }
}
