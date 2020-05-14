using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests.DataHelpTest
{
    public class NameAppTest
    {
        [Fact]
        public void NameApp_Text_correct()
        {
            DataHelp myData = new DataHelp();
            myData.NameApp.Should().Contain("Welcome: Console Calculator.\n");
        }
    }
}
