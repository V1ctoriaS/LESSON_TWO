// Задача 51: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.
// Сумма элементов главной диагонали: 1+9+2 = 12


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
void printInColor(string data)
{
Console.ForegroundColor = ConsoleColor.Magenta;
Console.Write(data);
Console.ResetColor();
}
void print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i == j)
            {
                printInColor(array[i,j] + "\t");
            }
            else
            {
                Console.Write(array[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}
int[,] Change(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i % 2 == 0 && j % 2 == 0)
            {
                array[i,j] = (int)Math.Pow(array[i,j], 2); //преобразовываем из double в int (int)
            }
        }
    }
    return array;
}
int FindSum(int[,] array)
{
    int result = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
            {
                result = result + array[i,j];
            }
        }
    }
    return result;
}    



int n = GetFromUser("Введите число строк");
int m = GetFromUser("Введите число столбцов");
int[,] array = get2DArray(n, m, 0, 100);
print2DArray(array);
Console.WriteLine();
int sum = FindSum(array);
Console.WriteLine($"Сумма элементов главной диагонали = {sum}");

