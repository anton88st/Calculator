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
        public void CompareInputNumberbySaveResultNumberTest(double value)
        {
            DataHelp myDataHelpTest = new DataHelp();
            myDataHelpTest.CompareInputNumberbySaveResult(value);
            Assert.Equal(value, myDataHelpTest.CompareInputNumberbySaveResult(value));
        } 
    }
}
