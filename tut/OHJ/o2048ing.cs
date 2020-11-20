using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
    //출력하기
    class PrintArray
    {
        public int i, j;

        public PrintArray(int [,] arr)
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
    class title
    {
        private static int[,] Move(int [,]arr, int k)
        {
            int i, j;

            //위
            if (k == 1)
            {
                for(i = 3; i>0; i--)
                {
                    for(j=0; j<4; j++)
                    {
                        if(arr[i, j] == 0)
                        {
                            continue;
                        }
                        if(arr[i, j] == arr[i - 1, j])
                        {
                            if (arr[0, j] == arr[i, j] && arr[1, j] == arr[i, j]
                                && arr[2, j] == arr[i, j] && arr[3, j] == arr[i, j])
                            {
                                arr[0, j] += arr[0, j];
                                arr[1, j] += arr[1, j];
                                arr[2, j] = 0;
                                arr[3, j] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 1:
                                        arr[i - 1, j] += arr[i, j];
                                        arr[i, j] = 0;
                                        break;
                                    case 2:
                                    case 3:
                                        if (arr[i, j] != arr[i - 2, j])
                                        {
                                            arr[i - 1, j] += arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        else
                                        {
                                            arr[i - 2, j] += arr[i - 1, j];
                                            arr[i - 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        break;

                                }
                            }
                        }
                        if (arr[i, j] != arr[i - 1, j])
                        {
                            if (arr[i - 1, j] != 0)
                                continue;
                            else
                            {
                                arr[i - 1, j] = arr[i, j];
                                arr[i, j] = 0;
                            }
                        }
                        else
                            k = 5;
                    }
                }
            }

            //아래
            if (k == 2)
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[i, j] == 0)
                        {
                            continue;
                        }
                        if (arr[i, j] == arr[i + 1, j])
                        {
                            if (arr[0, j] == arr[i, j] && arr[1, j] == arr[i, j]
                                && arr[2, j] == arr[i, j] && arr[3, j] == arr[i, j])
                            {
                                arr[2, j] += arr[0, j];
                                arr[3, j] += arr[1, j];
                                arr[0, j] = 0;
                                arr[1, j] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 2:
                                        arr[i + 1, j] += arr[i, j];
                                        arr[i, j] = 0;
                                        break;
                                    case 1:
                                    case 0:
                                        if (arr[i, j] != arr[i + 2, j])
                                        {
                                            arr[i + 1, j] += arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        else
                                        {
                                            arr[i + 2, j] += arr[i + 1, j];
                                            arr[i + 1, j] = arr[i, j];
                                            arr[i, j] = 0;
                                        }
                                        break;
                                }
                            }
                        }
                        if (arr[i, j] != arr[i + 1, j])
                        {
                            if (arr[i + 1, j] != 0)
                                continue;
                            else
                            {
                                arr[i + 1, j] = arr[i, j];
                                arr[i, j] = 0;
                            }
                        } 
                        else
                            k = 5;
                    }
                }
            }

            //왼쪽
            if (k == 3)
            {
                for (i = 3; i > 0; i--)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[j, i] == 0)
                        {
                            continue;
                        }
                        if (arr[j, i] == arr[j, i - 1])
                        {
                            if (arr[j, 0] == arr[j, i] && arr[j, 1] == arr[j, i]
                                && arr[j, 2] == arr[j, i] && arr[j, 3] == arr[j, i])
                            {
                                arr[j, 0] += arr[j, 2];
                                arr[j, 1] += arr[j, 3];
                                arr[j, 2] = 0;
                                arr[j, 3] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 1:
                                        arr[j, i - 1] += arr[j, i];
                                        arr[j, i] = 0;
                                        break;
                                    case 2:
                                    case 3:
                                        if (arr[j, i] != arr[j, i - 2])
                                        {
                                            arr[j, i - 1] += arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        else
                                        {
                                            arr[j, i - 2] += arr[j, i - 1];
                                            arr[j, i - 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        break;

                                }
                            }
                        }
                        if (arr[j, i] != arr[j, i - 1])
                        {
                            if (arr[j, i - 1] != 0)
                                continue;
                            else
                            {
                                arr[j, i - 1] = arr[j, i];
                                arr[j, i] = 0;
                            }
                        }
                        else
                            k = 5;
                    }
                }
            }

            //오른쪽
            if (k == 4)
            {
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (arr[j, i] == 0)
                        {
                            continue;
                        }
                        if (arr[j, i] == arr[j, i + 1])
                        {
                            if (arr[j, 0] == arr[j, i] && arr[j, 1] == arr[j, i]
                                && arr[j, 2] == arr[j, i] && arr[j, 3] == arr[j, i])
                            {
                                arr[j, 2] += arr[j, 0];
                                arr[j, 3] += arr[j, 1];
                                arr[j, 0] = 0;
                                arr[j, 1] = 0;
                            }
                            else
                            {
                                switch (i)
                                {
                                    case 2:
                                        arr[j, i + 1] += arr[j, i];
                                        arr[j, i] = 0;
                                        break;
                                    case 1:
                                    case 0:
                                        if (arr[j, i] != arr[j, i + 2])
                                        {
                                            arr[j, i + 1] += arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        else
                                        {
                                            arr[j, i + 2] += arr[j, i + 1];
                                            arr[j, i + 1] = arr[j, i];
                                            arr[j, i] = 0;
                                        }
                                        break;

                                }
                            }
                        }
                        if (arr[j, i] != arr[j, i + 1])
                        {
                            if (arr[j, i + 1] != 0)
                                continue;
                            else
                            {
                                arr[j, i + 1] = arr[j, i];
                                arr[j, i] = 0;
                            }
                        }
                        else
                            k = 5;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(30, 15);//창크기지정(가로,세로)
            int[,] Array = new int[4, 4];
            int i, j, k = 0, e, f;
       
            //array 초기화
            for (i=0; i<4; i++)
            {
                for(j=0; j<4; j++)
                {
                    Array[i, j] = 0;
                }
            }

            Random rand = new Random();//랜덤함수
            int a = 0, b = 0, c = 0, d = 0;
            //안 겹칠때까지 함
            while(a==c || b==d)
            {
                a = rand.Next(4);
                b = rand.Next(4);
                c = rand.Next(4);
                d = rand.Next(4);
            }
            Array[a, b] = 2;
            Array[c, d] = 2;

            PrintArray FirstArray = new PrintArray(Array);//랜덤으로 2 넣은거 출력

            while (true)
            {
                ConsoleKeyInfo keys;
                do
                {
                    if (Console.KeyAvailable)
                    {
                        keys = Console.ReadKey(true);
                        switch (keys.Key)
                        {
                            case ConsoleKey.UpArrow:
                                k = 1;
                                Array = Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.WriteLine();
                                        PrintArray UpArray = new PrintArray(Array);
                                        break;
                                    }
                               
                                }
                                break;
                            case ConsoleKey.DownArrow:
                                k = 2;
                                Array = Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.WriteLine();
                                        PrintArray DownArray = new PrintArray(Array);
                                        break;
                                    }
                                    
                                }
                                break;
                            case ConsoleKey.LeftArrow:
                                k = 3;
                                Array = Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.WriteLine();
                                        PrintArray LeftArray = new PrintArray(Array);
                                        break;
                                    }
                                    
                                }
                                break;
                            case ConsoleKey.RightArrow:
                                k = 4;
                                Array = Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.WriteLine();
                                        PrintArray RightArray = new PrintArray(Array);
                                        break;
                                    }
                                   
                                }
                                break;
                        }
                    }
                } while (k != 5);
            }
        }
    }
}
