// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9,9]. 
// Найдите отдельно сумму отрицательных и сумму положительных элементов массива.

int[] generateArray(int length, int start, int end)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(start, end + 1);    //+1 потому что поумолчанию последнее значение не используется рандомайзером
    }
    return result;
}

void printArray(int[] array)
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

//flag = 1 - положительный, flag = -1 тогда отрицательный
int getSumOfPositivOrNegative(int[] array, int flag = 1)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * flag > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = generateArray(12,-9,9); // 12 элементов, см.условие задачи
printArray(array);

sumOfPositive = getSumOfPositivOrNegative(array, 1);
sumOfNegative = getSumOfPositivOrNegative(array, -1);
Console.WriteLine($"Сумма положительных {sumOfPositive}");
Console.WriteLine($"Сумма отрицательных {sumOfNegative}");