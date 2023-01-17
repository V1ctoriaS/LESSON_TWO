// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumOfRange(int start, int end)
{
    int sum = 1;
    for (int i = start; i <= end; i++)
    {
        sum *= i;          //sum = sum * 1 
    }
    return sum;
}

int end = getUserData("Введите число А для  произведения ");
int sum = getSumOfRange(1, end);
Console.WriteLine($"Произведение чисел от 1 до {end} = {sum}");

