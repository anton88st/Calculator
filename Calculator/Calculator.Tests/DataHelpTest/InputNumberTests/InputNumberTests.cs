using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;

namespace Calculator.Tests
{
    public class InputNumberTests
    {
        [Theory]
        [InlineData("0")]
        [InlineData("-1")]
        [InlineData("1")]
        [InlineData("-1.5")]
        [InlineData("1.5")]
        public void InputNumber_stringNumber_ConvertToDouble(string value)
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputNumberInConsole("First")).Returns(value);
            DataHelp data = mock.Object;
            double num = Convert.ToDouble(value);
            Assert.Equal(num, data.InputNumber("First", 0));
        }
        [Fact]
        public void InputNumber_q_Exit()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputNumberInConsole("First")).Returns("q");
            DataHelp data = mock.Object;
            Action act = () => data.InputNumber("First", 0);
            act.Should().Throw<Exception>().WithMessage("Returning to the Main Menu...");
        }
        [Fact]
        public void InputNumber_s_Save()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputNumberInConsole("First")).Returns("s");
            DataHelp data = mock.Object;
            Assert.Equal(2, data.InputNumber("First", 2));
        }
    }
}
