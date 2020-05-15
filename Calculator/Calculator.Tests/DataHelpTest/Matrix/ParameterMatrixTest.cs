using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;


namespace Calculator.Tests.DataHelpTest
{
    public class ParameterMatrixTest
    {
        [Fact]
        public void CompareParameter_PositiveIntegerNumber_Result()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputConsoleParameterMatrix("A", "rows")).Returns("0");
            DataHelp myData = mock.Object;
            Assert.Equal(0, myData.ParameterMatrix("A", "rows"));
        }
        
    }
}
