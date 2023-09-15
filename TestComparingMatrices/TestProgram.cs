
using ComparingMatrices;


namespace TestComparingMatrices
{
    public class TestProgram
    {
        public static IEnumerable<object[]> ExpectedCountMatrix
            => new[]
            {
                new object[] { 0, new int[,]{ {0, 0, 0}, {0, 0, 0}, { 0, 0, 0 } } },
                new object[] { 0, new int[,]{ {1, 1, 1}, {1, 1, 1}, { 1, 1, 1 } } },
                new object[] { 0, new int[,]{ {int.MaxValue, int.MaxValue, int.MaxValue },
                                              {int.MaxValue, int.MaxValue, int.MaxValue },
                                              {int.MaxValue, int.MaxValue, int.MaxValue } }},

                new object[] { 0, new int[,]{ {int.MinValue, int.MinValue, int.MinValue },
                                              {int.MinValue, int.MinValue, int.MinValue },
                                              {int.MinValue, int.MinValue, int.MinValue } }}

            };

        [Theory]
        [MemberData(nameof(ExpectedCountMatrix))]
        public void Test_Equal_Matrices_Return_Zero_For_Count_Greater(int expectedCount, int[,] matrix)
        {
            int count = Program.CountGreaterElements(matrix, matrix);
            Assert.Equal(expectedCount, count);
        }



        public static IEnumerable<object[]> ExpectedCount_Matrix1_Matrix2
            => new[]
            {
                new object[]{9, new int[,] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } },
                                new int[,] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } }},

                new object[]{9, new int[,] { { 1, 3, 5 }, { 7, 9, 11 }, { 13, 15, 17 } },
                                new int[,] { { 0, 2, 4 }, { 6, 8, 10 }, { 12, 14, 16 } }}
            };
        [Theory]
        [MemberData(nameof(ExpectedCount_Matrix1_Matrix2))]
        public void Test_Matrix1_With_All_Elements_Greater_Than_Corresponding_Matrix2_Elements_Return_Nine
            (int expectedCount, int[,] matrix1, int[,] matrix2)
        {
            int count = Program.CountGreaterElements(matrix1, matrix2);
            Assert.Equal(expectedCount, count);
        }


    }
}