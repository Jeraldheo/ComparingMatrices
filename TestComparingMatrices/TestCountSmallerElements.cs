using ComparingMatrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComparingMatrices
{
    public class TestCountSmallerElements
    {
        [Theory]
        [InlineData(4, 3, 2, 9)]
        [InlineData(7, 1, 1, 9)]
        [InlineData(9, 0, 0, 9)]
        public void Test_Count_Greater_Equal_Elements_Return_Count_Smaller_Elements
            (int expectedCount, int countGreater, int countEqual, int matrixNumElements)
        {
            int count = Program.CountSmallerElements(countGreater, countEqual, matrixNumElements);
            Assert.Equal(expectedCount, count);
        }
    }
}
