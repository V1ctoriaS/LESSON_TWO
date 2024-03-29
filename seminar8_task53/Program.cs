﻿// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и 
// последнюю строку массива.

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
void printInColor(string data, ConsoleColor color)
{
    Console.ForegroundColor = color;
    System.Console.Write(data);
    Console.ResetColor();
}
void printHeadOfArray(int length)
{
    Console.Write("\t");
    for (int i = 0; i < length; i++)
    {
        printInColor(i + "\t", ConsoleColor.DarkGreen);
    }
    Console.WriteLine();
}
void printArray(int[,] array)
{
    printHeadOfArray(array.GetLength(1));
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printInColor(i+"\t",ConsoleColor.Cyan);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }
        Console.WriteLine();
    }   
    Console.WriteLine("------------------------------------------");
}
int[,]swapRows(int[,]array, int row1, int row2)
{
    for(int i = 0; i < array.GetLength(1); i++)
    {
        int tmp = array[row1, i];
        array[row1, i] = array[row2, i];
        array[row2, i] = tmp;
    }
    return array;
}

int[,] array = generate2DArray(10,7,-5,10);
printArray(array);
int[,] swapedArray = swapRows(array,0,array.GetLength(0) - 1);
printArray(swapedArray);