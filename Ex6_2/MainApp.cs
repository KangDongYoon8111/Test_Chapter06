using System;

namespace Ex6_2
{
    class MainApp
    {
        static void Main(string[] args)
        {
            double mean = 0;

            // 아래 형태로 보내는 인수의 형태는 기본형(값(복사)형식)
            // Mean(1, 2, 3, 4, 5, mean);
            // 변경 1
            // Mean(1, 2, 3, 4, 5,ref mean);
            // 변경 2
            Mean(1, 2, 3, 4, 5, out mean);

            Console.WriteLine("평균 : {0}", mean);
        }

        public static void Mean(double a, double b, double c,
            double d, double e, double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }

        //public static void Mean(double a, double b, double c,
        //    double d, double e,ref double mean)
        //{
        //    mean = (a + b + c + d + e) / 5;
        //}

        public static void Mean(double a, double b, double c,
            double d, double e, out double mean)
        {
            mean = (a + b + c + d + e) / 5;
        }
    }
}
