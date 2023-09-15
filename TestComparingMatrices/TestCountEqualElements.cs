using ComparingMatrices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestComparingMatrices
{
    public class TestCountEqualElements
    {
        public static IEnumerable<object[]> ExpectedCount_Matrix
            => new[]
            {
                new object[] { 9, new int[,]{ {0, 0, 0}, {0, 0, 0}, { 0, 0, 0 } } },
                new object[] { 9, new int[,]{ {1, 1, 1}, {1, 1, 1}, { 1, 1, 1 } } },
                new object[] { 9, new int[,]{ {int.MaxValue, int.MaxValue, int.MaxValue },
                                              {int.MaxValue, int.MaxValue, int.MaxValue },
                                              {int.MaxValue, int.MaxValue, int.MaxValue } }},

                new object[] { 9, new int[,]{ {int.MinValue, int.MinValue, int.MinValue },
                                              {int.MinValue, int.MinValue, int.MinValue },
                                              {int.MinValue, int.MinValue, int.MinValue } }}

            };

        [Theory]
        [MemberData(nameof(ExpectedCount_Matrix))]
        public void Test_Equal_Matrices_Return_Nine(int expectedCount, int[,] matrix)
        {
            int count = Program.CountEqualElements(matrix, matrix);
            Assert.Equal(expectedCount, count);
        }
    }
}
