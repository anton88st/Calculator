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
        [Fact]
        public void InputNumber_Firstand25_ConvertToDouble()
        {
            var mock = new Mock<DataHelp>();
            mock.Setup(obj => obj.InputNumberInConsole("First")).Returns("25");
            DataHelp data = mock.Object;
            Assert.Equal(25, data.InputNumber("First", 0));
        }
    }
}
