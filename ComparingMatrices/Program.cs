

using System.Collections.Immutable;

namespace ComparingMatrices
{
    public class Program
    {
        static void Main(string[] args)
        {

        }

        public static int CountGreaterElements(int[,] matrix1, int[,] matrix2)
        {
            int count = 0;
            for(int i = 0; i<matrix1.GetLength(0); i++)
            {
                for(int j = 0; j<matrix2.GetLength(1); j++)
                {
                    if (matrix1[i, j] > matrix2[i,j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}