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
            mock.Setup(obj => obj.InputConsoleParameterMatrix("A", "rows")).Returns("1");
            DataHelp myData = mock.Object;
            Assert.Equal(1, myData.ParameterMatrix("A", "rows"));
        }
        [Fact]
        public void CompareParameter_q_Result()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputConsoleParameterMatrix("A", "rows")).Returns("q");
            DataHelp myData = mock.Object;
            Action act = () => myData.ParameterMatrix("A", "rows");
            act.Should().Throw<Exception>().WithMessage("Returning to the Main Menu...");
        }
    }
}
