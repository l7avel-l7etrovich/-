﻿// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] SpiralFilledMatrix(int row, int col)
{
    int[,] array = new int[row, col];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array.GetLength(0) * array.GetLength(1))
    {
        array[i, j] = temp++;
        if (i <= j + 1 && i + j < array.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= array.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > array.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return array;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[ ");
            if (matrix[i, j] < 10)
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"0{matrix[i, j]} ");
                else Console.Write($"0{matrix[i, j]} ]");
            }
            else
            {
                if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]} ");
                else Console.Write($"{matrix[i, j]} ]");
            }
        }
        Console.WriteLine();
    }
}

Console.Clear();
Console.WriteLine("Программа заполняет двухмерный массив по спирали.");
Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());
int[,] mySpiralMatrix = SpiralFilledMatrix(row, col);
PrintMatrix(mySpiralMatrix);