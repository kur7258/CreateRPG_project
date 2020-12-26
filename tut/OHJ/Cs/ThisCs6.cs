using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThisCs6
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price : {price}");
        }
    }

    class Program
    {
        static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        static void PrintProfile(string name, string phone = "")//=""하면 없으면 걍 빈칸
        {
            if(name == "")
            {
                Console.WriteLine("이름입력하세요");
                return;
            }
            Console.WriteLine("Name: {0}, Phone: {1}", name, phone);
        }

        //ref보다out(결과없으면 오류떠줌)이 더 안전 
        static void Swap(ref int a, ref int b)
        {
            int t = a;
            a = b;
            b = t;
        }

        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        //눈치껏 소수냐 정수냐에 따라서 저4개중에 1개선택함
        static int Plus(int a, int b)
        {
            return a + b;
        }
        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Plus(int a, double b)
        {
            return a + b;
        }
        static double Plus(double a, double b)
        {
            return a + b;
        }

        static int Sum(params int[] args)//params쓰면 갯수 지가알아서 지정해줌
        {
            int sum = 0;

            for(int i = 0; i<args.Length; i++)
            {
                if(i>0)
                {
                    Console.Write(", ");
                }
                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();
            return sum;
        }

        static string ToLowerString(string input)//대문자 소문자로 만들기
        {
            var arr = input.ToCharArray();
            for(int i = 0; i<arr.Length; i++)
            {
                arr[i] = ToLowerChar(i);//소문자 변환기
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90)//A~Z 아스키값
                    return arr[i];
                else//a~z 아스키값 97:122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }
        static void Main(string[] args)
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result);

            result = Calculator.Minus(8, 4);
            Console.WriteLine(result);

            Console.WriteLine();

            Console.WriteLine("10번째 피보나치 수 : {0}", Fibonacci(10));

            PrintProfile("", "1231232");
            PrintProfile("dfsf", "1231232");

            Console.WriteLine();

            int x = 3, y = 4;
            Console.WriteLine("x : {0}, y : {1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("x : {0}, y : {1}", x, y);

            Console.WriteLine();

            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();//변함
            int normal_local_price = carrot.GetPrice();//무조건 price값

            carrot.PrintPrice();//price값대로 나옴
            Console.WriteLine($"Ref Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            Console.WriteLine($"Local Price : {ref_local_price}");
            Console.WriteLine($"Normal Local Price : {normal_local_price}");

            Console.WriteLine();

            int a = 20, b = 3;

            Divide(a, b, out int c, out int d);
            Console.WriteLine("a : {0}, b : {1}\na/b = {2}, a%b = {3}", a, b, c, d);

            Console.WriteLine();

            Console.WriteLine(Plus(1,2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1, 2.1));
            Console.WriteLine(Plus(1.1, 2.1));

            Console.WriteLine();

            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Sum : {0}", sum);

            Console.WriteLine();

            PrintProfile(name: "fsdfds", phone: "3255425");
            PrintProfile(phone: "342432", name: "fsdfds");
            PrintProfile("fsdfds", "3255425");
            PrintProfile("fsdfds", phone: "3255425");
            PrintProfile("fsdfds");

            Console.WriteLine();

            Console.WriteLine(ToLowerString("Hi!"));
            Console.WriteLine(ToLowerString("Good"));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}
