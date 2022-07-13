// Демонстрация решения
// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = 1; i <= a; i++)
{
    sum += i;

    if (i < a)
    {
        Console.Write($"{i} + ");
    }
    else Console.Write($"{i} = ");
}

Console.WriteLine($"{sum}");