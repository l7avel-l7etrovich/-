// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();

int[,] CreateMatrixRndInt(int row, int col)
{
    int[,] array = new int[row, col];
    Random rnd = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    System.Console.WriteLine($"Сгенерированные матрицы: ");
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

int[,] MatrixMultiplication(int[,] a, int[,] b)
{
    int[,] result = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < result.GetLength(1); k++)
            {
                sum += a[i, k] * b[k, j];
            }
            result[i, j] = sum;
            
        }
    } return result;
}



Console.WriteLine("Введите кол-во строк для первой матрицы: ");
int row = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов для первой матрицы: ");
int col = Convert.ToInt32(Console.ReadLine());

int[,] matrix1 = CreateMatrixRndInt(row, col);

Console.WriteLine($"Введите кол-во строк для второй матрицы: ");
int row1 = Convert.ToInt32(Console.ReadLine());
while (col != row1)
{
    Console.WriteLine($"Кол-во строк должно быть равно {col}! Введите кол-во строк для второй матрицы: ");
    row1 = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Введите кол-во столбцов для второй матрицы: ");
int col1 = Convert.ToInt32(Console.ReadLine());

int[,] matrix2 = CreateMatrixRndInt(row1, col1);
PrintMatrix(matrix1);
PrintMatrix(matrix2);
int[,] resMatrix = MatrixMultiplication(matrix1, matrix2);
PrintMatrix(resMatrix);