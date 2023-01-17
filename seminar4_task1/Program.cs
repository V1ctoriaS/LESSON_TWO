// Напишите программу, которая на вход принимает число (А) и показывает сумм чисел от 1 до А

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getSumOfRange(int start, int end)
{
    int sum = 0;
    for (int i = start; i <= end; i++)
    {
        sum += i;          //sum = sum + 1 
    }
    return sum;
}

int end = getUserData("Введите число А для  получения суммы ");
int sum = getSumOfRange(1, end);
Console.WriteLine($"Сумма чисел от 1 до {end} = {sum}");