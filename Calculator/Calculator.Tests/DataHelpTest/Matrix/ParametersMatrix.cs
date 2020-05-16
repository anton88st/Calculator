using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;

namespace Calculator.Tests.DataHelpTest.Matrix
{
    public class ParametersMatrix
    {
       [Fact]
        public void ParametersMatrix_1()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputConsoleParameterMatrix("A", "rows")).Returns("2");
            mock.Setup(obj => obj.InputConsoleParameterMatrix("A", "columns")).Returns("1");
            DataHelp mydata = mock.Object;
            mydata.ParametersMatrix("A");
            Assert.Equal(2, mydata.CleanrowsMatrix);
            Assert.Equal(1, mydata.CleancolsMatrix);
        }
    }
}
