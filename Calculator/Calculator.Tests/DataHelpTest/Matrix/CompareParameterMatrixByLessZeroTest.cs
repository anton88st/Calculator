using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using FluentAssertions;


namespace Calculator.Tests.DataHelpTest.Matrix
{
    public class CompareParameterMatrixByLessZeroTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        public void CompareParameter_NumberLessThanZero_Exception(int value)
        {
            DataHelp myData = new DataHelp();
            Action act = () => myData.CompareParameterMatrixByLessZero(value);
            act.Should().Throw<Exception>().WithMessage("Input number can't be less than 1");
        }
    }
}
