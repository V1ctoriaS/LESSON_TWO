// See https://aka.ms/new-console-template for more information
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)  //void - это метод, который ничего не возвращает (нельзя использовать с return)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
        }
        index++;
        return position;
    }
}


int[] array = new int[10];

FillArray(array); //эта команда вызывает массив
PrintArray(array); //эта команда его печатает
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);