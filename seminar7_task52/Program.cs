//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int GetFromUser(string message)  // получаем значение элемента от пользователя
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int[,] get2DArray(int colLength, int rowLength, int start, int finish) //эта функция создает двумерный массив [,]
{
    int[,] array = new int[colLength, rowLength];   //colLength - столбцы, rowLength - строки
    for (int i = 0; i < colLength; i++)
    {
        for (int j = 0; j < rowLength; j++)
        {
            array[i,j] = new Random().Next(start, finish+1 );
        }
    }
    return array;
} 

void print2DArray(int[,] array)  // эта функция напечатала созданный ранее массив
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");   //"\t" - задает табуляцию (чтобы таблица была ровная)
        }
        Console.WriteLine();
    }
}
int FindSum(int[,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];   
        }
        sum = sum / array.GetLength(0);
        Console.Write($"Среднее арифметическое {sum} ");
        Console.WriteLine(" ");
        sum = 0;
    }
    return sum;
} 

int n = GetFromUser("Введите число строк");
int m = GetFromUser("Введите число столбцов");
Console.WriteLine();
int[,] array = get2DArray(n, m, 0, 100);
print2DArray(array);
int sum = FindSum(array);
//Console.WriteLine($"Сумма элементов главной диагонали = {sum}");
//int sum = FindSum(array);
//Console.WriteLine($" Среднее арифметическое элементов в каждом столбце {sum}");
