using System;

namespace Task4
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

            if (firstNumber != thirdNumber)
            {
                int tmp = firstNumber;
                firstNumber = thirdNumber;
                thirdNumber = tmp;

                int newNumber = firstNumber * 100 + secondNumber * 10 + thirdNumber;
                Console.WriteLine($"Новое число: {newNumber}");
                Console.WriteLine($"{number} -> {newNumber}");
            }
            else
            {
                Console.WriteLine("Число не требует преобразования");
            }

            
        }
    }
}
