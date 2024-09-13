using System;
namespace prakticheskaya1
{
    class Programm2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите температуру в гр.Фаренгейта:");
            double TF =
            Convert.ToDouble(Console.ReadLine());
            double TC = (TF - 32) * 5 / 9;
            Console.WriteLine("Данная температура гр.Цельсия={0}",TC);
        }

    }
}