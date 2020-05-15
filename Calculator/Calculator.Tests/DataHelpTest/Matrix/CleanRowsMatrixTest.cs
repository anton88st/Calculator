using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;

namespace Calculator.Tests.DataHelpTest
{
    public class CleanrowsMatrixTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1.5)]
        [InlineData(1.5)]
        public void SetRowNumber_int_SameResult(int value)
        {
            DataHelp myData = Mock.Of<DataHelp>(a => a.CleanrowsMatrix == value);
            int Num = myData.CleanrowsMatrix;
            Assert.Equal(value, Num);

        }
    }
}
