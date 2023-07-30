// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29
using System;

class Program
{
    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        else if (m > 0 && n == 0)
            return Ackermann(m - 1, 1);
        else
            return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static void Main()
    {
        Console.WriteLine("Введите m:");
        int m;
        while (!int.TryParse(Console.ReadLine(), out m))
        {
            Console.WriteLine("Ошибка ввода. Вводите положительное целое число: ");
        }

        Console.WriteLine("Введите n:");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n))
        {
            Console.WriteLine("Ошибка ввода. Вводите положительное целое число: ");
        }

        if (m < 0 || n < 0)
        {
            Console.WriteLine("Введены некорректные данные. Оба числа должны быть положительными.");
        }
        else
        {
            int result = Ackermann(m, n);
            Console.WriteLine($"Значение функции Аккермана для m={m} и n={n} равно: {result}");
        }
    }
}
