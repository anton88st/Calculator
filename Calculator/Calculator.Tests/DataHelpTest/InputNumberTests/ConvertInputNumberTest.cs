using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace Calculator.Tests
{
    public class ConvertInputNumberTest
    {
        [Theory]
        [InlineData("0")]
        [InlineData("-1.5")]
        [InlineData("1.5")]
        public void ConvertNumberInputNumberTest(string value)
        {
            DataHelp myDataHelpTest = new DataHelp();
            object theObject = myDataHelpTest.ConvertInputNumber(value);
            theObject.Should().BeOfType<double>(value, typeof(string));
        }
        [Theory]
        [InlineData("anton")]
        [InlineData(" ")]
        [InlineData("+")]
        public void ConvertStringInputNumberTest(string value)
        {
            DataHelp myDataHelpTest1 = new DataHelp();
            Assert.Throws<FormatException>(() => myDataHelpTest1.ConvertInputNumber(value));
        }
        [Fact]
        public void ConvertNullInputNumberTest()
        {
            DataHelp myDataHelpTest2 = new DataHelp();
            Assert.Throws<ArgumentNullException>(() => myDataHelpTest2.ConvertInputNumber(null));
        }
    }
}
