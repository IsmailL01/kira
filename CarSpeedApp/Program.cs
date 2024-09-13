using System;
namespace prakticheskaya1
{
    class Programm1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость 1-го автомобиля V1 км/ч:");
            double V1 =
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите скорость 2-го автомобиля V2 км/ч:");
            double V2 =
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите изначальное расстояние между автомобилям S км:");
            double S =
            Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите время T ч:");
            double T =
            Convert.ToDouble(Console.ReadLine());
            double x = (V1 * T) + (V2 * T)+S;
            Console.WriteLine("Расстояние между автомобилями через {0} часов:{1} км",T,x);
        }

    }
}