using System;
namespace prakticheskaya1
{
    class Programm3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение X:");
            double X =
            Convert.ToDouble(Console.ReadLine());
            double Y = 4*Math.Pow(X - 3, 6)-7*Math.Pow(X - 3, 3)+2;
            Console.WriteLine(" Y={0}",Y);
        }

    }
}