//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
//452 -> 11
//
//82 -> 10
//
//9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());


int SumNum(int a)
{
    int sum = 0;
    for (int i = 0; a > 0; i++)
    {
        sum = sum + a % 10;
        a /= 10;
    }
    return sum;
}
int SumNum1 = SumNum(num);
Console.WriteLine($"Сумма цифр из числа {num} = {SumNum1}");