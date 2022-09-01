// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку
// массива.

Console.Clear();

Console.WriteLine("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Исходный массив: ");

int[,] CreateMatrixRndInt(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0, 100);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    System.Console.WriteLine($"Сгенерированная матрица: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3}, ");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

void ChangeRow(int[,] array)
{
    int idx1 = 0;
    int idx2 = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int row = array[idx1, i]; // 1, 2, ...
        array[idx1, i] = array[idx2, i]; // 1 = 8, 2 = 9, ...
        array[idx2, i] = row; // 8 = 1, 9 = 2, ...
    }
}

int[,] arrayResult = CreateMatrixRndInt(row, col);
PrintMatrix(arrayResult);
ChangeRow(arrayResult);
System.Console.WriteLine();
PrintMatrix(arrayResult);