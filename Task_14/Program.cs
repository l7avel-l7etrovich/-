/* 14. Напишите программу, которая принимает на
вход число и проверяет, кратно ли оно
одновременно 7 и 23.
14 -> нет
46 -> нет
161 -> да */

System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(System.Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine($"{num} кратно и 7, и 23");
}
else System.Console.WriteLine("Нет, не кратно");