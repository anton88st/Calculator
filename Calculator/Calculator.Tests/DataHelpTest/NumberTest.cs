using System;
using System.Collections.Generic;
using System.Text;
using Moq;
using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class NumberTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1.5)]
        [InlineData(1.5)]
        public void SetNumber_double_SameResult(double value)
        {
            DataHelp myData = Mock.Of<DataHelp>(a => a.Number == value);
            double Num = myData.Number;
            Assert.Equal(value, Num);

        }

    }
}
