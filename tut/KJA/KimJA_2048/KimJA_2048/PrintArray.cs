using System;

namespace KimJA_2048
{
    class PrintArray
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo c;  //키입력
            Console.SetWindowSize(100, 40);

            //배열 생성
            int[][] array = new int[4][];
            array[0] = new int[] { 0, 0, 0, 0 };
            array[1] = new int[] { 0, 0, 0, 0 };
            array[2] = new int[] { 0, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 0, 0 };

            //랜덤 함수 생성
            Random r = new Random();
            int ran = r.Next(0, 4);
            int ran1 = r.Next(0, 4);
            while (true)
            {
                if (array[ran][ran1] == 0)  // 랜덤한 위치가 0인지 아닌지 확인
                {
                    array[ran][ran1] = 2;   // 0이면 2를 넣는다
                    break;
                }
                else  // 0일경우 다시 랜덤 위치로 이동
                {
                    ran = r.Next(0, 4);
                    ran1 = r.Next(0, 4);
                    continue;
                }
            }
            //배열 출력
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(" {0} ", array[i][j]);
                }
                Console.WriteLine("");
            }
            //반복
            while (true)
            {
                //키입력 확인 변수
                c = Console.ReadKey();
                switch (c.Key)
                {
                    case ConsoleKey.LeftArrow: //왼쪽 방향키 입력
                        for (int k = 0; k < 4; k++)
                        {
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
                                    else if (array[i][j - 1] != array[i][j])
                                    {
                                        for (int a = 0; a < array.Length; a++)
                                        {
                                            for (int b = 0; b < array.Length - 1; b++)
                                            {
                                                int temp = array[a][b + 1];
                                                if (array[a][b] == 0)
                                                {
                                                    array[a][b] = temp;
                                                    array[a][b + 1] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case ConsoleKey.RightArrow: //오른쪽 방향키 입력
                        for (int k = 0; k < 4; k++)
                        {
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
                                    else if (array[i][j + 1] != array[i][j])
                                    {
                                        for (int a = 0; a < array.Length; a++)
                                        {
                                            for (int b = 3; b > 0; b--)
                                            {
                                                int temp = array[a][b - 1];
                                                if (array[a][b] == 0)
                                                {
                                                    array[a][b] = temp;
                                                    array[a][b - 1] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        for (int k = 0; k < 4; k++)
                        {
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
                                    else if (array[j + 1][i] != array[j][i])
                                    {
                                        for (int b = 0; b < array.Length; b++)
                                        {
                                            for (int a = 3; a > 0; a--)
                                            {
                                                int temp = array[a - 1][b];
                                                if (array[a][b] == 0)
                                                {
                                                    array[a][b] = temp;
                                                    array[a - 1][b] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        for (int k = 0; k < 4; k++)
                        {
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
                                    else if (array[j - 1][i] != array[j][i])
                                    {
                                        for (int b = 0; b < array.Length; b++)
                                        {
                                            for (int a = 0; a < array.Length - 1; a++)
                                            {
                                                int temp = array[a + 1][b];
                                                if (array[a][b] == 0)
                                                {
                                                    array[a][b] = temp;
                                                    array[a + 1][b] = 0;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                ran = r.Next(0, 4);
                ran1 = r.Next(0, 4);
                while (true)
                {
                    if (array[ran][ran1] == 0)  // 랜덤한 위치가 0인지 아닌지 확인
                    {
                        array[ran][ran1] = 2;   // 0이면 2를 넣는다
                        break;
                    }
                    else  // 0일경우 다시 랜덤 위치로 이동
                    {
                        ran = r.Next(0, 4);
                        ran1 = r.Next(0, 4);
                        continue;
                    }
                }
                Console.Clear();
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
}
