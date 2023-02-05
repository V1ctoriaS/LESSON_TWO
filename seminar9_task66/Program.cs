// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M:");
int M = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число M:");
int N = int.Parse(Console.ReadLine()!);

void NumberSum (int M, int N, int sum)
{
    if (M > N) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (M++);
    NumberSum(M, N, sum);
}

NumberSum(M, N, 0);
