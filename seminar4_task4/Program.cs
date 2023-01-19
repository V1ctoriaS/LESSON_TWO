// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе

int number = getUserData("Введите число: ");
int len = getNumberOfDigit(number);
SumNumbers(number, len);

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int getNumberOfDigit(int number)
{
    int NumberOfDigit = 0;
    while (number > 0)
    {
        number = number / 10;
        NumberOfDigit++;
    }
    return NumberOfDigit;
}


void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр = {sum}");
}

