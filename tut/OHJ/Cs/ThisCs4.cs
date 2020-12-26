using System;
using System.Collections;
using static System.Console;

namespace ThisCs4
{
    class Program
    {
        static void Main(string[] args)
        {
            //널인지 검사
            ArrayList a = null;
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");//널이라 안뜸
            WriteLine($"{a?[0]}");//널이라 안뜸
            WriteLine($"{a?[1]}");//널이라 안뜸

            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");//널아니라서 뜸
            WriteLine($"{a?[0]}");//널아니라서 뜸
            WriteLine($"{a?[1]}");//널아니라서 뜸

            Console.WriteLine();

            //간략하게 널인지 검사
            int? num = null;
            Console.WriteLine($"{num ?? 0}");//널이면 0
            num = 99;
            Console.WriteLine($"{num ?? 0}");

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");//널이면 Default
            str = "sddfds";
            Console.WriteLine($"{str ?? "Default"}");

            Console.WriteLine();

            //쉬프트 연산자
            Console.WriteLine("<<");//왼쪽으로 옮김
            int b = 1;
            Console.WriteLine("b: {0:D5} (0x{0:X8})", b);
            Console.WriteLine("b << 1: {0:D5} (0x{0:X8})", b << 1);//b*2^1
            Console.WriteLine("b << 2: {0:D5} (0x{0:X8})", b << 2);//b*2^2
            Console.WriteLine("b << 5: {0:D5} (0x{0:X8})", b << 5);//b*2^5

            Console.WriteLine(">>");//오른쪽으로 옮김
            int bb = 225;
            Console.WriteLine("bb: {0:D5} (0x{0:X8})", bb);
            Console.WriteLine("bb >> 1: {0:D5} (0x{0:X8})", bb >> 1);//bb/2^1
            Console.WriteLine("bb >> 2: {0:D5} (0x{0:X8})", bb >> 2);//bb/2^2
            Console.WriteLine("bb >> 5: {0:D5} (0x{0:X8})", bb >> 5);//bb/2^5

            int bbb = -225;
            Console.WriteLine("bbb: {0:D5} (0x{0:X8})", bbb);
            Console.WriteLine("bbb >> 1: {0:D5} (0x{0:X8})", bbb >> 1);
            Console.WriteLine("bbb >> 2: {0:D5} (0x{0:X8})", bbb >> 2);
            Console.WriteLine("bbb >> 5: {0:D5} (0x{0:X8})", bbb >> 5);
        }
    }
}
