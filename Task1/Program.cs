using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int number = 465;
            Console.WriteLine($"Исходное число: {number}");
            int firstNumber = number / 100;
            Console.WriteLine($"Первая цифра числа: {firstNumber}");
            int secondNumber = (number / 10) % 10;
            Console.WriteLine($"Вторая цифра числа: {secondNumber}");
            int thirdNumber = number % 10;
            Console.WriteLine($"Третья цифра числа: {thirdNumber}");
            int sum = firstNumber + secondNumber + thirdNumber;
            Console.WriteLine($"Сумма цифр числа: {sum}");
        }
    }
}
