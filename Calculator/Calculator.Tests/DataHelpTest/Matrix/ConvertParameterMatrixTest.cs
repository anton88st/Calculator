using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;

namespace Calculator.Tests.DataHelpTest.Matrix
{
    public class ConvertParameterMatrixTest
    {
        [Theory]
        [InlineData("0")]
        [InlineData("-1")]
        [InlineData("1")]
        public void ConvertParameter_IntegerNumber_Result(string value)
        {
            DataHelp myData = new DataHelp();
            object numResult = myData.ConvertParameterMatrix(value);
            numResult.Should().BeOfType<int>(value, typeof(string));
        }
        [Theory]
        [InlineData("1.5")]
        [InlineData("-1.5")]
        public void ConvertParameter_FractionalNumber_Exception(string value)
        {
            DataHelp myData = new DataHelp();
            Action act = () => myData.ConvertParameterMatrix(value);
            act.Should().Throw<Exception>().WithMessage("Input string was not in a correct format.");
        }
    }
}
