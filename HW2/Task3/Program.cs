using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            int firstNumber = number / 100;
            Console.WriteLine($"Первая цифра числа: {firstNumber}");
            int secondNumber = (number / 10) % 10;
            Console.WriteLine($"Вторая цифра числа: {secondNumber}");
            int thirdNumber = number % 10;
            Console.WriteLine($"Третья цифра числа: {thirdNumber}");

            bool booleanVariable;
            if(secondNumber <= firstNumber && secondNumber > thirdNumber)
            {
                booleanVariable = true;
            }
            else
            {
                booleanVariable = false;
            }
            Console.WriteLine($"Число: {number} ({booleanVariable})");
        }
    }
}
