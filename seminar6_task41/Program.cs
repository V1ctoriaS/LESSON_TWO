// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int mes = getUserData("Введите желаемое количество чисел");
int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string SetOfNumbers (int number)
{
    string arr = string.Empty;
    int result = 0;
    while (number => 8)
    {
        if (number > 0)
        {
            result++;
            arr = $"{result}";
        }
        else
        {
            result = result + 0;
            arr = $"{result}";
        }
    }
    return result;
}

string numbers = SetOfNumbers(number);
Console.WriteLine($"Число {numbers}");
