using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            double number = Convert.ToDouble(Console.ReadLine());
            bool booleanVariable = number == (int)number;
            Console.WriteLine($"{number} ({booleanVariable})");
        }
    }
}
