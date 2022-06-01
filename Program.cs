using System;

namespace vn_mode_csharp_dz20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray = new int[3, 3];
            int secondRowSum = 0;
            int productOfNumbersColumn = 1;
            Random random = new Random();
            Console.WriteLine("Исходная матрица:\n");

            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    myArray[i, j] = random.Next(1, 9);
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
            for(int i = 0; i < myArray.GetLength(1); i++)
            {
                secondRowSum += myArray[1, i];
            }
            Console.WriteLine($"\nСумма второй строки = {secondRowSum}");
            for (int i = 0; i < myArray.GetLength(0); i++)
            {
                productOfNumbersColumn *= myArray[i, 0];
            }
            Console.WriteLine($"Произведение чисел первого столбца = {productOfNumbersColumn}");
        }
    }
}
