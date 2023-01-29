//Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1; [1, 2, 3, 6, 2] -> 0; [10, 11, 12, 13, 14] -> 5

int[] generateArray(int length, int start, int end)   // эта функция создает массив
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);    //+1 потому что поумолчанию последнее значение не используется рандомайзером
    }
    return result;
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

int FindNumber (int [] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= start && array[i] <= end)  //&& - это и (это и это)
        {
            count++;
        }
        else
        {
            count = count + 0;
        }
    }
    return count;
}

int[] array = generateArray(10, -100,100);
printArray(array);
int Number = FindNumber (array, 10, 99);
Console.WriteLine($"Количество элементов массива в диапозоне от 10 до 99 = {Number}");
