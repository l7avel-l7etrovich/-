/*16. Напишите программу, которая принимает на
вход два числа и проверяет, является ли одно
число квадратом другого.
5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет */

Console.WriteLine("Введите первое число: ");
int firstDigit = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondDigit = Convert.ToInt32(Console.ReadLine());

if (firstDigit * firstDigit == secondDigit || secondDigit * secondDigit == firstDigit)
{
    System.Console.WriteLine("Одно из чисел является квадратом друго.");
}
else System.Console.WriteLine("Ни одно из чисел является квадратом друго.");
