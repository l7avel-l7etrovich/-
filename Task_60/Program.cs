// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] ArrayKub(int a, int b, int c)
{
    int[,,] array = new int[a, b, c];
    int count = 10;
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                array[j, k, i] = count++;
            }
        }
    }
    return array;
}

void PrintMatrix(int[,,] array)
{
    System.Console.WriteLine($"Сгенерированная матрица: ");
    for (int i = 0; i < array.GetLength(2); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                System.Console.Write(array[j, k, i]);
                System.Console.Write($"({j},{k},{i}) ");
                
                
            }
            Console.WriteLine();
        }
        
    }
}
int[,,] qwerty = ArrayKub(2, 2, 2);
PrintMatrix(qwerty);
