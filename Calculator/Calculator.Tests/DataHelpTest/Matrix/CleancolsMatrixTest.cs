using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;

namespace Calculator.Tests.DataHelpTest
{
    public class CleancolsMatrixTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1.5)]
        [InlineData(1.5)]
        public void SetColNumber_int_SameResult(int value)
        {
            DataHelp myData = Mock.Of<DataHelp>(a => a.CleancolsMatrix == value);
            int Num = myData.CleancolsMatrix;
            Assert.Equal(value, Num);
        }
    }
}
