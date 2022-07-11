/* Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Программа запрашивает число N и выводит таблицу кубов чисел");
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

int i = 1;

int[] tableq = new int[n];

while (i <= n)
{
    tableq[i - 1] = i * i * i;
    i++;
}

Console.WriteLine($"Таблица квадратов чисел от 1 до {n}: {String.Join(", ", tableq)}");