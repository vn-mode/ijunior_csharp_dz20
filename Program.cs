using System;

namespace vn_mode_csharp_dz20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3];
            int secondRowSum = 0;
            int productOfNumbersColumn = 1;
            int minNumber = 1;
            int maxNumber = 9;
            Random random = new Random();
            Console.WriteLine("Исходная матрица:\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(minNumber, maxNumber);
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                secondRowSum += matrix[1, i];
            }
            Console.WriteLine($"\nСумма второй строки = {secondRowSum}");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                productOfNumbersColumn *= matrix[i, 0];
            }
            Console.WriteLine($"Произведение чисел первого столбца = {productOfNumbersColumn}");
        }
    }
}
