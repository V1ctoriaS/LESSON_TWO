// Напишите программу, которая на вход принимает число и выдает количество цифр в этом числе

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

int number = getUserData("Введите число");
int NumberOfDigit = getNumberOfDigit(number);
Console.WriteLine($"В числе {number} - {NumberOfDigit} цифр");