// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Задайте первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m > n)
{
    int min = n;
    n = m;
    m = min;

}
int a = m + 1;
int result = NaturalNamber(m, n, a);
Console.WriteLine(result);

int NaturalNamber(int m, int n, int a)
{
    if (a == n + 1) return m;
    else return NaturalNamber(m + a, n, ++a);
}