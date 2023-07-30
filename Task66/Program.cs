// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = CalculateSum(M, N);

Console.WriteLine($"Сумма натуральных чисел в промежутке от {M} до {N} равна: {sum}");


static int CalculateSum(int M, int N)
{

    if (M == N)
        return M;
    return M + CalculateSum(M + 1, N);
}

