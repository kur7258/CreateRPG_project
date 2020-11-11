using System;

namespace KimJA_2048
{
    class PrintArray
    {        
        static void Main(string[] args)
        {
            ConsoleKeyInfo c;  //키입력

            int[][] array = new int[4][];
            array[0] = new int[] { 8, 6, 4, 2 };
            array[1] = new int[] { 0, 0, 2, 2 };
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
            c = Console.ReadKey(); //키입력 확인 변수
            switch (c.Key)
            {
                case ConsoleKey.LeftArrow: //왼쪽 방향키 입력
                    for (int i = 0; i < array.Length; i++) // 세로행 반복
                    {
                        for (int j = 3; j > 0; j--) // 가로행 반복
                        {  // 바로 앞 행이 0인지 확인 또는 앞열과 뒷열이 같은지 확인
                            if (array[i][j - 1] == 0 || array[i][j - 1] == array[i][j])
                            {
                                int temp1 = array[i][j - 1];
                                int temp2 = array[i][j];
                                int sum = temp1 + temp2;
                                array[i][j] = 0;
                                array[i][j - 1] = sum;
                            }
                            else if (array[i][j] == 0)
                            {
                                continue;
                            }
                        }
                    }
                    break;
                case ConsoleKey.RightArrow: //오른쪽 방향키 입력
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array.Length - 1; j++)
                        { // 앞행이 0인지 또는 앞행과 뒷행이 같은지 확인
                            if (array[i][j + 1] == 0 || array[i][j + 1] == array[i][j])
                            {
                                int temp1 = array[i][j + 1];
                                int temp2 = array[i][j];
                                int sum = temp1 + temp2;
                                array[i][j] = 0;
                                array[i][j + 1] = sum;
                            }
                        }
                    }
                    break;
                case ConsoleKey.DownArrow:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 0; j < array.Length - 1; j++)
                        {   // 앞행이 0인지 또는 앞행과 뒷행이 같은지 확인
                            if (array[j + 1][i] == 0 || array[j + 1][i] == array[j][i])
                            {
                                int temp1 = array[j][i];
                                int temp2 = array[j + 1][i];
                                int sum = temp1 + temp2;
                                array[j][i] = 0;
                                array[j + 1][i] = sum;
                            }
                        }
                    }
                    break;
                case ConsoleKey.UpArrow:
                    for (int i = 0; i < array.Length; i++)
                    {
                        for (int j = 3; j > 0; j--)
                        {   // 앞행이 0인지 또는 앞행과 뒷행이 같은지 확인
                            if (array[j - 1][i] == 0 || array[j - 1][i] == array[j][i])
                            {
                                int temp1 = array[j - 1][i];
                                int temp2 = array[j][i];
                                int sum = temp1 + temp2;
                                array[j][i] = 0;
                                array[j - 1][i] = sum;
                            }
                        }
                    }
                    break;

            }
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
