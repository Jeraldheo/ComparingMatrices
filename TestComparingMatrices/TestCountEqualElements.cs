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
                new object[] { 9, new int[,]{ {5, 1, 2}, {7, 11, 15}, { 31, 0, 55 } } },
                new object[] { 9, new int[,]{ {int.MaxValue, int.MaxValue, int.MaxValue },
                                              {int.MaxValue, int.MaxValue, int.MaxValue },
                                              {int.MaxValue, int.MaxValue, int.MaxValue } }},

                new object[] { 9, new int[,]{ {int.MinValue, int.MinValue, int.MinValue },
                                              {int.MinValue, int.MinValue, int.MinValue },
                                              {int.MinValue, int.MinValue, int.MinValue } }}

            };

        [Theory]
        [MemberData(nameof(ExpectedCount_Matrix))]
        public void Test_Equal_Matrices_Return_Count_Nine(int expectedCount, int[,] matrix)
        {
            int count = Program.CountEqualElements(matrix, matrix);
            Assert.Equal(expectedCount, count);
        }


        public static IEnumerable<object[]> ExpectedCount_Matrix1_Different_Matrix2
            => new[]
            {
                new object[]{0, new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } },
                                new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }},

                new object[]{0, new int[,] { { 1, 3, 5 }, { 7, 9, 11 }, { 13, 15, 17 } },
                                new int[,] { { 0, 2, 4 }, { 6, 8, 10 }, { 12, 14, 16 } }},

                new object[]{0, new int[,] { { 7, 10, 5 }, { 35, 17, 92 }, { 88, 32, 55 } },
                                new int[,] { { 1, 15, 2 }, { 11, 44, 34 }, { 12, 24, 27 } }},

                new object[]{0, new int[,]{ {int.MaxValue, int.MaxValue, int.MaxValue },
                                            {int.MaxValue, int.MaxValue, int.MaxValue },
                                            {int.MaxValue, int.MaxValue, int.MaxValue }},
                                new int[,]{ {int.MinValue, int.MinValue, int.MinValue },
                                            {int.MinValue, int.MinValue, int.MinValue },
                                            {int.MinValue, int.MinValue, int.MinValue }}}
            };

        [Theory]
        [MemberData(nameof(ExpectedCount_Matrix1_Different_Matrix2))]
        public void Test_Matrix1_All_Elements_Different_Matrix2_Return_Count_Zero
            (int expectedCount, int[,] matrix1, int[,] matrix2)
        {
            int count = Program.CountEqualElements(matrix1, matrix2);
            Assert.Equal(expectedCount, count);
        }
    }
}
