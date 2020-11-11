using System;

namespace BrainCSharp
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;

            Console.WriteLine($"g={g}, h={h}");

            float i = 3.1415_9265_3589_7932_3846f;
            double j = 3.1415_9265_3589_7932_3846;
            decimal k = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.WriteLine(k);

            byte l = 0b1000;//2진수
            byte m = 0XF0;//16진수
            uint o = 0x1234_abcd;//16진수

            Console.WriteLine(l);
            Console.WriteLine(m);
            Console.WriteLine(o);

            uint p = uint.MaxValue;//uint 최댓값 1111 1111
            p = p + 1;//11111111 + 1 = 100000000

            Console.WriteLine(p);

            object q = 213;//object는 모두 가능
            object r = "dfsdfd";
            object s = true;
            object t = 3.323231213134;

            Console.WriteLine(q);
            Console.WriteLine(r);
            Console.WriteLine(s);
            Console.WriteLine(t);

            int u = 123;
            object v = (object)u;//a를 박싱해서 힙에 저장
            int w = (int)v;//b를 언박싱해 스택에 저장

            Console.WriteLine(u);
            Console.WriteLine(v);
            Console.WriteLine(w);

            double x = 3.3243;
            object y = x;
            double z = (double)y;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
        }
    }
}