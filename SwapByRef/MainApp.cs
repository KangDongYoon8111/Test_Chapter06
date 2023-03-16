using System;

namespace SwapByRef
{
    class MainApp
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        static void Main(string[] args)
        {
        }
    }
}
