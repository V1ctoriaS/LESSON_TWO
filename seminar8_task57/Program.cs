// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит 
// информацию о том, сколько раз встречается элемент входных данных.
//Набор данных
//Частотный массив
//{ 1, 9, 9, 0, 2, 8, 0, 9 }
//0 встречается 2 раза
//1 встречается 1 раз
//2 встречается 1 раз
//8 встречается 1 раз
//9 встречается 3 раза
//1, 2, 3
//4, 6, 1
//2, 1, 6
//1 встречается 3 раза
//2 встречается 2 раз
//3 встречается 1 раз
//4 встречается 1 раз
//6 встречается 2 раза

int[,] generate2DArray(int rowLength, int colLength, int start, int finish)
{
    int[,] array = new int[rowLength, colLength];
    for (int i = 0; i < rowLength; i++)
    {
        for (int j = 0; j < colLength; j++)
        {
            array[i,j] = new Random().Next(start,finish +1);
        }
    }
    return array;
}
void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }   
}
int[,] FindNumber(int[,] array)
{
    count = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = i; j < array.GetLength(1); j++)
        {
            int tmp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = tmp;
        }
    }
    return array;
}
int[,] array = generate2DArray(5,5,0,50);
printArray(array);