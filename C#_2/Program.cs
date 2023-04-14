/*Напишите программу, которая на вход принимает 
позиции элемента в двумерном массиве, и возвращает 
значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;

Clear();
Write("Введите номер строки массива: ");
int rows = int.Parse(ReadLine());

Write("Введите номер столбца массива: ");
int columns = int.Parse(ReadLine());

int[,] array = new int [5, 5];
Array(array);
PrintArray(array);

if (rows > array.GetLength(0) || columns > array.GetLength(1))
{
    WriteLine("Такого числа в массиве нет");
}
else
{
    WriteLine($"Значение элемента {rows} строки и {columns} столбца равно {array[rows - 1, columns - 1]}");
}

void Array(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 101);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}