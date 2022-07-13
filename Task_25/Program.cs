//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
//3, 5 -> 243 (3⁵)
//
//2, 4 -> 16 (4⁵)


Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int StepNum(int a, int b) // Возводит целое число в степень

{
    int ansver = 1;
    for (int i = 0; i < b; i++)
    {
        ansver *= a;
    }
    return ansver;
}
int StepNum1 = StepNum(num1, num2);
Console.WriteLine(StepNum1);





