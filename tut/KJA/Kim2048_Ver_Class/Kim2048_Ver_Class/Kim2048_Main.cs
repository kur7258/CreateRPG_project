using System;

namespace Kim2048_Ver_Class
{
    class Kim2048_Main
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo c;
            ReadKey arr = new ReadKey ();
            arr.Array();
            arr.MakeRandom();
            arr.ShowArray();

            while (true)
            {
                c = Console.ReadKey();
                switch (c.Key)
                {
                    case ConsoleKey.LeftArrow:
                        arr.LeftKey();
                        break;
                    case ConsoleKey.RightArrow:
                        arr.RightKey();
                        break;
                    case ConsoleKey.DownArrow:
                        arr.DownKey();
                        break;
                    case ConsoleKey.UpArrow:
                        arr.UpKey();
                        break;
                }
                Console.Clear();
                arr.MakeRandom();
                arr.ShowArray();
            }
        }
    }
}
