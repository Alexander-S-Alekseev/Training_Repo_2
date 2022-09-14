﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
// вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
Console.WriteLine("Введите число строк: ");
int Lines = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int Columns = Convert.ToInt32(Console.ReadLine());
double[,] Array = new double[Lines, Columns];
FillArray (Array);
PrintArray (Array);

void FillArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
    }
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write (arr[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}