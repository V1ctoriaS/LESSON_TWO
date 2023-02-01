// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int getUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

string ArrayOfNumbers (int number)
{
    int i = 0;
    int sum = 0;
    string result = string.Empty;
    while(number > i)
    {
        Console.WriteLine("Введите число");
        int num = int.Parse(Console.ReadLine()!);
        if (num > 0)
        {
            sum = sum + 1;
        }
        i++;
        if(number > i)
        {
            result = ($"{result} {num}, ");
        }
        else
        {
            result = ($"{result} {num} ");
        }
    }
    result = result = ($"{result} = {sum}");
    return result;
}


int number = getUserData("Введите желаемое количество чисел");
string res = ArrayOfNumbers(number);
//int set = SumOfNumbers(array);
Console.WriteLine($"{res}");

