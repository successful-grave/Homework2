using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите радиус мишени R: ");
            double radius = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите координату х1: ");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите коориданату y1: ");
            int y1 = Convert.ToInt32(Console.ReadLine());

            double shotRadius = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            bool shot;

            if(shotRadius <= radius)
            {
                shot = true;
            }    
            else
            {
                shot = false;
            }
            Console.WriteLine($"Попадание: {shot}");
        }
    }
}
