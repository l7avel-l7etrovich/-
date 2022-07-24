// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223 -> 3

int NumbersGreaterThanZero(int[] a)
{
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] > 0)
        {
            count += 1;
        }
    }
    return count;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i == 0) Console.Write("[");
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i] + "]");

    }
}

Console.WriteLine("Введите числа и нажмите Enter: ");
int[] input = Console.ReadLine().Split().ToArray().Select(x => int.Parse(x)).ToArray();
Console.WriteLine();

int numbers = NumbersGreaterThanZero(input);
PrintArray(input);
Console.WriteLine(numbers);