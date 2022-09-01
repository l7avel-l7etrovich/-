// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.Clear();
Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());
int sum = NaturalNumbers(n, 0);
Console.WriteLine(sum);

int NaturalNumbers(int n, int sum)
{
    sum += n % 10;
    if (n / 10 == 0) return sum;
    else return NaturalNumbers(n / 10, sum);
}