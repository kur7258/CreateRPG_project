using System;

namespace KimJA_2048
{
    class PrintArray
    {        
        static void Main(string[] args)
        {
            int[][] array = new int[4][];
            array[0] = new int[] { 0, 0, 0, 0 };
            array[1] = new int[] { 0, 0, 0, 0 };
            array[2] = new int[] { 0, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 0, 0 };

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(" {0} ", array[i][j]);
                }
                Console.WriteLine("");
            }
        }
    }
}
