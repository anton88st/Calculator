using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests
{
    public class Class1
    {
        [Fact]
        public void Ant()
        {
            
            var mockAdd = new Mock<Calculator>();
            mockAdd.Setup(x => x.Add()).Verifiable();
            Calculator myCalc = new Calculator();
            myCalc.MathOperations("a");
            mockAdd.VerifyAll();
        }
    }
}
