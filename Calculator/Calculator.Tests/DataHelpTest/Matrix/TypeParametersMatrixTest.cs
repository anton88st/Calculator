using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Moq;

namespace Calculator.Tests.DataHelpTest.Matrix
{
   public class TypeParametersMatrixTest
    {
        [Fact]
        public void TypeParameterMatrix_Number_Matrix()
        {
            DataHelp mydata = Mock.Of<DataHelp>(p => p.CleanrowsMatrix == 0);
            mydata = Mock.Of<DataHelp>(a => a.CleancolsMatrix == 0);
            int[,] Matrics = new int[0, 0];
            mydata.TypeParametersMatrix("A");
            Assert.Equal(Matrics, mydata.TypeParametersMatrix("A"));
        }
    }
}
