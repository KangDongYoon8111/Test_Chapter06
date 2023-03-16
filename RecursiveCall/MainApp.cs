using System;
namespace RecursiveCall
{
    class MainApp
    {
        static void Main(string[] args)
        {
            MainApp a = new MainApp();
            int result = a.Factorial(5);
            Console.WriteLine(result);
        }

        int Factorial(int n)
        {
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}
