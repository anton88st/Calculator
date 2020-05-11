using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace Calculator.Tests.InputNumberTest
{
    public class CompareInputNumberByExitTest
    {
        [Fact]
        public void Compare_q_Exit()
        {
            DataHelp myDataHelpTest = new DataHelp();
            Action act = () => myDataHelpTest.CompareInputNumberByExit();
            act.Should().Throw<Exception>().WithMessage("Returning to the Main Menu...");
        }
    }
}
