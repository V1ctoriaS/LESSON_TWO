// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

int length = getInFromUser("Введите длину массива");
int[] generateArray(int length, int start, int end)   // эта функция создает массив
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);    //+1 потому что поумолчанию последнее значение не используется рандомайзером
    }
    return result;
}
int getInFromUser(string message)   //принимаем длину массива от пользователя, а первоначальные значения зададим сами позднее
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

int[] array = generateArray(length, 100,999); 
printArray(array);


int sum = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i] % 2 == 0)
sum++;
}
Console.WriteLine($"Количество четных чисел - {sum}");




//int[] arrayy = generateArray(length, 100,999); 
//printArray(arrayy);
