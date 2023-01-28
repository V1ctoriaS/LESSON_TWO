// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [9, 0, 17, 168, 3] -> да

int[] generateArray(int length, int start, int end)   // эта функция создает массив
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);    //+1 потому что поумолчанию последнее значение не используется рандомайзером
    }
    return result;
}
int getInFromUser(string message)   //принимаем массив от пользователя
{
    Console.WriteLine(message);
    int userInt = int.Parse(Console.ReadLine()!);
    return userInt;
}
void printArray(int[] array)       //эта функция выводит ранее созданный массив на печать
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] );
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
int FindNumber (int [] array, int number)
{
    int n = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number)
        {return i;
        break;}
    }
    return n;
}

int length = getInFromUser("Введите длину массива");
int findNumber = getInFromUser("Введите искомое число");
int[] array = generateArray(length, -100,100);
printArray(array);
int n = FindNumber(array, findNumber);
if (n == -1)
{
    Console.WriteLine($"Нет");
}
else {Console.WriteLine($"Да");}