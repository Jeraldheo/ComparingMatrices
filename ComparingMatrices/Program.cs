

using System.Collections.Immutable;

namespace ComparingMatrices
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[,] { { 17, 9, 36 }, { 8, 7, 3 }, { 15, 28, 87 } };
            int[,] matrix2 = new int[,] { { 9, 21, 36 }, { 16, 65, 4 }, { 12, 28, 31 } };

            int countGreaterElements1 = CountGreaterElements(matrix1, matrix2);
            int countEqualElements    = CountEqualElements(matrix1, matrix2);
            int countGreaterElements2 = CountSmallerElements(countGreaterElements1, countEqualElements, matrix1.Length);

            Console.WriteLine($"El arreglo 1 contiene {countGreaterElements1} elementos mayores");
            Console.WriteLine($"El arreglo 2 contiene {countGreaterElements2} elementos mayores");
            Console.WriteLine($"Existen {countEqualElements} elementos iguales en ambos arreglos");
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

        public static int CountEqualElements(int[,] matrix1, int[,] matrix2)
        {
            int count = 0;
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    if (matrix1[i, j] == matrix2[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        public static int CountSmallerElements(int countGreater, int countEqual, int matrixNumElements)
        {
            int count = 0;
            count = matrixNumElements - (countGreater + countEqual);
            return count;
        }
    }
}