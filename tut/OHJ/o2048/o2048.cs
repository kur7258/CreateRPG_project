using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048
{
   
    class title
    {
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
                while(true)
                { 
                    if (Console.KeyAvailable)
                    {
                        keys = Console.ReadKey(true);
                        switch (keys.Key)
                        {
                            case ConsoleKey.UpArrow:
                                k = 1;
                                Move UpArray = new Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.Clear();
                                        PrintArray UpfArray = new PrintArray(Array);
                                        break;
                                    }
                               
                                }
                                break;
                            case ConsoleKey.DownArrow:
                                k = 2;
                                Move DownArray = new Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.Clear();
                                        PrintArray DownfArray = new PrintArray(Array);
                                        break;
                                    }
                                    
                                }
                                break;
                            case ConsoleKey.LeftArrow:
                                k = 3;
                                Move LeftArray = new Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.Clear();
                                        PrintArray LeftfArray = new PrintArray(Array);
                                        break;
                                    }
                                    
                                }
                                break;
                            case ConsoleKey.RightArrow:
                                k = 4;
                                Move RightArray = new Move(Array, k);
                                while (true)
                                {
                                    e = rand.Next(4);
                                    f = rand.Next(4);
                                    if (Array[e, f] == 0)
                                    {
                                        Array[e, f] = 2;
                                        Console.Clear();
                                        PrintArray RightfArray = new PrintArray(Array);
                                        break;
                                    }
                                   
                                }
                                break;
                        }
                    }
                }
            }
        }
    }
}
