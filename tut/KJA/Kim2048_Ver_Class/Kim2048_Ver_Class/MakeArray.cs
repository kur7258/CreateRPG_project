using System;
using System.Collections.Generic;
using System.Text;

namespace Kim2048_Ver_Class
{
    class MakeArray
    {
        public int[][] array = new int[4][];

        public MakeArray() {}

        public void Array()
        {
            array[0] = new int[] { 0, 0, 0, 0 };
            array[1] = new int[] { 0, 0, 0, 0 };
            array[2] = new int[] { 0, 0, 0, 0 };
            array[3] = new int[] { 0, 0, 0, 0 };
        }
        public void ShowArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    Console.Write(" {0} ", array[i][j]);
                }
                Console.WriteLine("");
            }
        }
        public void MakeRandom()
        {
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
        }
    }
}
