//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8


Console.WriteLine("Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.!");
Console.Write("Введите число больше 1! ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 4;
while (num <= 1)
{
    while (num < 1)
    {
        Console.Write("Введенное число меньше 1! Введите число заново. ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write("Введное число равно 1! Введите число заново. ");
    num = Convert.ToInt32(Console.ReadLine());
}
Console.Write("2");
while (count <= num)
{
    Console.Write($", {count}");
    count += 2;
}