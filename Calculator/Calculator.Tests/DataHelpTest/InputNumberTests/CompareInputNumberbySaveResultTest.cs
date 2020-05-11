using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace Calculator.Tests.InputNumberTest
{
    public class CompareInputNumberbySaveResultTest
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1.5)]
        [InlineData(-1.5)]
        public void Compare_InputNumber_SaveResult(double value)
        {
            DataHelp myDataHelpTest = new DataHelp();
            myDataHelpTest.CompareInputNumberbySaveResult(value);
            Assert.Equal(value, myDataHelpTest.CompareInputNumberbySaveResult(value));
        } 
    }
}
