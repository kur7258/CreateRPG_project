using System;

namespace _2048
{
    class PrintArray
    {
        public int i, j;

        public PrintArray(int[,] arr)
        {
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine();
                for (j = 0; j < 4; j++)
                {
                    Console.Write($"{arr[i, j]} ");
                }
            }
        }

    }

}
