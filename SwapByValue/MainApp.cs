using System;

namespace SwapByValue
{
    class MainApp
    {
        public static void Swap(int a, int b, int c)
        {
            int temp = b;
            int temp2 = c;
            c = a;
            a = temp;
            b = temp2;        
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;
            int z = 5;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(x, y, z);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}
