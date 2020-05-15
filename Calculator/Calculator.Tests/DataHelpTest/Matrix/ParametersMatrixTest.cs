using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;

namespace Calculator.Tests.DataHelpTest.Matrix
{
    public class ParametersMatrixTest
    {
        [Fact]
        public void SetParameter_Number_CleanResultRows()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.ParameterMatrix("A", "rows")).Returns(2);
            DataHelp myData = mock.Object;
            myData.ParametersMatrix("A");
            Assert.Equal(2, myData.CleanrowsMatrix);
        }
        [Fact]
        public void SetParameter_Number_CleanResultCols()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.ParameterMatrix("A", "columns")).Returns(2);
            DataHelp myData = mock.Object;
            myData.ParametersMatrix("A");
            Assert.Equal(2, myData.CleancolsMatrix);
        }

    }
}
