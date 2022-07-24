// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}

double[] Average(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(1)];

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int ansver = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            ansver = ansver + matrix[j, i];
        }
        array[i] = (double)ansver / matrix.GetLength(0);
        
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write("{0:N2} ", array[i, j]);
            else Console.Write("{0:N2} ]", array[i, j]);
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length -1) Console.Write("{0:N2} ", array[i]);
        else Console.Write("{0:N2} ]", array[i]);
        
    }
}

int[,] asd = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(asd);
System.Console.WriteLine();
double[] qwe = Average(asd);
PrintArray(qwe);

